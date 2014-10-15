namespace CarStore.Client
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using CarStore.Data;
    using CarStore.Model;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.IO;
    using System.Xml.Linq;

    public class Program
    {
        private static void ProcessDirectory(string targetDirectory, CarStoreDatabase db)
        {
            string[] fileEntries = Directory.GetFiles(targetDirectory, "*.json");
            foreach (string fileName in fileEntries)
            {
                ProcessFile(fileName, db);
            }
        }

        private static void ProcessFile(string filename, CarStoreDatabase db)
        {
            var jsonText = File.ReadAllText(filename);
            var jsonObj = JsonConvert.DeserializeObject<List<CarJsonModel>>(jsonText);
            int index = 0;

            Console.WriteLine("Processing file: " + filename);
            foreach (var singleEntity in jsonObj)
            {
                var savedCity = db.Cities.FirstOrDefault(x => x.Name == singleEntity.Dealer.City);
                if (savedCity == null)
                {
                    savedCity = new City()
                    {
                        Name = singleEntity.Dealer.City
                    };
                }

                var savedManufacturer = db.Manufacturers.FirstOrDefault(x => x.Name == singleEntity.ManufacturerName);
                if (savedManufacturer == null)
                {
                    savedManufacturer = new Manufacturer()
                    {
                        Name = singleEntity.ManufacturerName,
                    };
                }

                var newDealer = new Dealer()
                {
                    Name = singleEntity.Dealer.Name,
                    City = savedCity
                };

                var newCar = new Car()
                {
                    Year = new DateTime(singleEntity.Year, 1, 1),
                    Transmission = singleEntity.TransmissionType,
                    Manufacturer = savedManufacturer,
                    Model = singleEntity.Model,
                    Price = singleEntity.Price,
                    Dealer = newDealer
                };

                db.Cars.Add(newCar);
                db.SaveChanges();

                if (index % 100 == 0)
                {
                    Console.Write('.');
                }
                index++;
            }
            Console.WriteLine("File data added!");
        }

        static void Main(string[] args)
        {
            var db = new CarStoreDatabase();
            db.Configuration.AutoDetectChangesEnabled = false;
            ProcessDirectory(@"..\..\JsonFiles", db); // Seed db!

            
            var xmlElements = XElement.Load(@"..\..\queries.xml");

            foreach (var xmlElement in xmlElements.Elements())
            {
                var fileName = xmlElement.Attribute("OutputFileName").Value;
                
                var xmlSearchResult = new XElement("Cars");

                var listOfCars = db.Cars.AsQueryable();
                var orderBy = "";
                var filterBy = "";
                var typeOfComparision = "";

                foreach (var command in xmlElement.Elements())
                {
                    if (command.Name == "OrderBy")
                    {
                        orderBy = command.Value;
                    }

                    if (command.Name == "WhereClauses")
                    {
                        foreach (var whereClause in command.Elements())
                        {
                            filterBy = whereClause.Attribute("PropertyName").Value;
                            typeOfComparision = whereClause.Attribute("Type").Value;
                            
                            // Doesn't perform .Equals because references!
                            if (filterBy == "City")
                            {
                                listOfCars = listOfCars.Where(x => x.Dealer.City.Name == whereClause.Value);
                            }

                            if (filterBy == "Year")
                            {
                                var date = new DateTime(int.Parse(whereClause.Value), 1, 1);
                                listOfCars = listOfCars.Where(x => x.Year >= date);
                            }

                            if (filterBy == "Price")
                            {
                                decimal price = decimal.Parse(whereClause.Value);
                                listOfCars = listOfCars.Where(x => x.Price == price);
                            }

                            if (filterBy == "Manufacturer")
                            {
                                listOfCars = listOfCars.Where(x => x.Manufacturer.Name == whereClause.Value);
                            }

                            if (filterBy == "Dealer")
                            {
                                listOfCars = listOfCars.Where(x => x.Dealer.Name == whereClause.Value);
                            }

                            if (filterBy == "City")
                            {

                                listOfCars = listOfCars.Where(x => x.Dealer.City.Name == whereClause.Value); 
                            }
                        }
                    }
                }

                if (orderBy == "Id")
                {
                    listOfCars = listOfCars.OrderBy(x => x.CarId);
                }
                var resultSet = listOfCars.ToList();

                foreach (var car in resultSet)
                {
                    var xmlCar = new XElement("Car");
                    xmlCar.Add(new XElement("TransmissionType", car.Transmission));
                    var xmlDealer = new XElement("Dealer");
                    xmlDealer.SetAttributeValue("Name", car.Dealer.Name);
                    xmlDealer.Add(new XElement("Cities", new XElement("City", car.Dealer.City.Name)));
                    xmlCar.Add(xmlDealer);
                    xmlSearchResult.Add(xmlCar);
                }

                
                xmlSearchResult.Save(fileName);
            }
            Console.WriteLine("Xml parsed look bin\\debug folder for results!!!");

            db.Configuration.AutoDetectChangesEnabled = true;
        }
    }
}