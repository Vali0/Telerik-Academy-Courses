using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyGeometry
{
    class ExtendedFigureControler : FigureController
    {
        public override void ExecuteFigureCreationCommand(string[] splitFigString)
        {
            switch (splitFigString[0])
            {
                case "circle":
                    {
                        Vector3D a = Vector3D.Parse(splitFigString[1]);
                        double radius = double.Parse(splitFigString[2]);
                        this.currentFigure = new Circle(a, radius);
                        break;
                    }
                case "cylinder":
                    {
                        Vector3D bot = Vector3D.Parse(splitFigString[1]);
                        Vector3D top = Vector3D.Parse(splitFigString[2]);
                        double radius = double.Parse(splitFigString[3]);
                        this.currentFigure = new Cylinder(bot, top,radius);
                        break;
                    }
                default:
                    {
                        base.ExecuteFigureCreationCommand(splitFigString);
                    }

                    break;
            }
            this.EndCommandExecuted = false;
        }

        protected override void ExecuteFigureInstanceCommand(string[] splitCommand)
        {
            switch (splitCommand[0])
            {
                case "area":
                    {
                        if(this.currentFigure is IAreaMeasurable)
                        {
                            Console.WriteLine("{0:0.00}", ((IAreaMeasurable)this.currentFigure).GetArea());
                        }
                        else
                        {
                            Console.WriteLine("undefined");
                        }
                        break;
                    }
                case "volume":
                    {
                        if (this.currentFigure is IVolumeMeasurable)
                        {
                            Console.WriteLine("{0:0.00}", ((IVolumeMeasurable)this.currentFigure).GetVolume());
                        }
                        else
                        {
                            Console.WriteLine("undefined");
                        }
                        break;
                    }
                case "normal":
                    {
                        if (this.currentFigure is IFlat)
                        {
                            Console.WriteLine("{0:0.00}", ((IFlat)this.currentFigure).GetNormal());
                        }
                        else
                        {
                            Console.WriteLine("undefined");
                        }
                        break;
                    }
                default:
                    {
                        base.ExecuteFigureInstanceCommand(splitCommand);
                        break;
                    }
            }
        }
    }
}