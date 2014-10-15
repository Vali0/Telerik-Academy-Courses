namespace Task02SimpleFunctionality
{
    using Task01ConnectToNorthwind;
    using System.Linq;
    using System;

    public static class DataAccessObject
    {

        // Task02
        public static void AddCustomer(string id, string companyName, string contactName = null, string contactTitle = null,
            string address = null, string city = null, string region = null, string postalCode = null,
            string country = null, string phone = null, string fax = null)
        {
            var dbContext = new NorthwindDatabase();

            using (dbContext)
            {
                var customer = new Customer()
                {
                    CustomerID = id,
                    CompanyName = companyName,
                    ContactName = contactName,
                    ContactTitle = contactTitle,
                    Address = address,
                    City = city,
                    Region = region,
                    PostalCode = postalCode,
                    Country = country,
                    Phone = phone,
                    Fax = fax
                };

                dbContext.Customers.Add(customer);
                dbContext.SaveChanges();
            }
        }

        public static void UpdateCustomer(string id, string companyName, string contactName = null, string contactTitle = null,
            string address = null, string city = null, string region = null, string postalCode = null,
            string country = null, string phone = null, string fax = null)
        {
            var dbContext = new NorthwindDatabase();

            using (dbContext)
            {
                var selectedCustomer = dbContext.Customers.FirstOrDefault(x => x.CustomerID == id);

                selectedCustomer.CompanyName = companyName ?? selectedCustomer.CompanyName;
                selectedCustomer.ContactName = contactName ?? selectedCustomer.ContactName;
                selectedCustomer.ContactTitle = contactTitle ?? selectedCustomer.ContactTitle;
                selectedCustomer.Address = address ?? selectedCustomer.Address;
                selectedCustomer.City = city ?? selectedCustomer.City;
                selectedCustomer.Region = region ?? selectedCustomer.Region;
                selectedCustomer.PostalCode = postalCode ?? selectedCustomer.PostalCode;
                selectedCustomer.Country = country ?? selectedCustomer.Country;
                selectedCustomer.Phone = phone ?? selectedCustomer.Phone;
                selectedCustomer.Fax = fax ?? selectedCustomer.Fax;

                dbContext.SaveChanges();
            }
        }

        public static void RemoveCustomer(string id)
        {
            var dbContext = new NorthwindDatabase();

            using (dbContext)
            {
                var selectedCustomer = dbContext.Customers.FirstOrDefault(x => x.CustomerID == id);
                dbContext.Customers.Remove(selectedCustomer);

                dbContext.SaveChanges();
            }
        }

        // Task03
        public static void ShowCustomersOrderedIn1997ForCanada()
        {
            var dbContext = new NorthwindDatabase();

            using (dbContext)
            {
                var customers = dbContext.Orders
                                         .Where(o => o.ShipCountry == "Canada" && o.OrderDate.Value.Year == 1997)
                                         .GroupBy(c => c.Customer.CustomerID);

                foreach (var customer in customers)
                {
                    Console.WriteLine(customer.Key);
                }
            }
        }

        // Task04
        public static void ShowCustomersOrderedIn1997ForCanadaSqlQuery()
        {
            var dbContext = new NorthwindDatabase();

            using (dbContext)
            {
                var query = "SELECT CustomerID FROM Orders o WHERE YEAR(o.OrderDate) = 1997 AND o.ShipCountry LIKE 'Canada' GROUP BY CustomerID";
                var queryResult = dbContext.Database.SqlQuery<string>(query);

                foreach (var customer in queryResult)
                {
                    Console.WriteLine(customer);
                }
            }
        }

        // Task05
        public static void ShowOrdersByGivenRegionAndPeriod(string region, DateTime startDate, DateTime endDate)
        {
            var dbContext = new NorthwindDatabase();

            using (dbContext)
            {
                var orders = dbContext.Orders.Where(o => o.ShipRegion == region &&
                                                         (o.OrderDate >= startDate && o.OrderDate <= endDate));
                
                foreach (var order in orders)
                {
                    Console.WriteLine(order.ShipName);
                }
            }
        }

        // Task06
        public static void CreateNorthwindCopyIfNotExist()
        {
            var dbContext = new NorthwindDatabase();

            using (dbContext)
            {
                if (dbContext.Database.CreateIfNotExists())
                {
                    Console.WriteLine("Created!");
                }
                else
                {
                    Console.WriteLine("Already exist!");
                }
            }
        }

        // Task07
        public static void TwoParalelConnectionsToSameDate()
        {
            var firstDbContext = new NorthwindDatabase();

            var firstTransaction = firstDbContext.Database.BeginTransaction();
            using (firstTransaction)
            {
                var selectedCustomerByFirstConnection = firstDbContext.Customers.FirstOrDefault(c => c.CustomerID == "ALFKI");
                selectedCustomerByFirstConnection.Region = "CHIRPAN";

                firstDbContext.SaveChanges();
                firstTransaction.Commit();
            }

            var secondDbContext = new NorthwindDatabase();
            var secondTransaction = secondDbContext.Database.BeginTransaction();
            using (secondTransaction)
            {
                var selectedCustomerBySecondConnection = secondDbContext.Customers.FirstOrDefault(c => c.CustomerID == "ALFKI");
                selectedCustomerBySecondConnection.Region = "SOFIA";

                secondDbContext.SaveChanges();
                secondTransaction.Commit();
            }
        }

        // Task08 - look other project named Task08EmployeeTerritory

        // Task09
        public static void AddOrder(string customerId, int? employeeId = null, DateTime? orderDate = null,
            DateTime? requiredDate = null, DateTime? shippedDate = null, int? shipVia = null,
            decimal? freight = null, string shipName = null, string shipAddress = null, string shipCity = null,
            string shipRegion = null, string shipPostalCode = null, string shipCountry = null)
        {
            var dbContext = new NorthwindDatabase();

            using (dbContext)
            {
                using (var saveOrderTransaction = dbContext.Database.BeginTransaction())
                {
                    try
                    {
                        var newOrder = new Order()
                        {
                            CustomerID = customerId,
                            EmployeeID = employeeId,
                            OrderDate = orderDate,
                            RequiredDate = requiredDate,
                            ShippedDate = shippedDate,
                            ShipVia = shipVia,
                            Freight = freight,
                            ShipName = shipName,
                            ShipAddress = shipAddress,
                            ShipCity = shipCity,
                            ShipRegion = shipRegion,
                            ShipPostalCode = shipPostalCode,
                            ShipCountry = shipCountry
                        };

                        dbContext.Orders.Add(newOrder);
                        dbContext.SaveChanges();
                        saveOrderTransaction.Commit();
                    }
                    catch (Exception)
                    {
                        saveOrderTransaction.Rollback();
                    }
                }
            }
        }

        // Task10
        public static void ShowIncomesForGivenSupplierAndPeriod(string supplier, DateTime startDate, DateTime endDate)
        {
            var dbContext = new NorthwindDatabase();
            using (dbContext)
            {
                var result = dbContext.usp_FindTotalIncomesByGivenNameAndPeriod(supplier, startDate, endDate);
                foreach (var item in result)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}