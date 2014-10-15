using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyGeometry
{
    class Cylinder : Figure, IVolumeMeasurable, IAreaMeasurable
    {
        private Vector3D bot, top;

        public double Radius { get; private set; }

        public Vector3D Bot
        {
            get
            {
                return this.vertices[0];
            }
            set
            {
                this.bot = vertices[0];
            }
        }

        public Vector3D Top
        {
            get
            {
                return this.vertices[1];
            }
            set
            {
                this.top = vertices[1];
            }
        }
        
        public Cylinder(Vector3D bot, Vector3D top, double radius) : base(bot,top)
        {
            this.Radius = radius;
        }

        public double GetVolume()
        {
            double height = Math.Sqrt(Math.Pow((this.Top.X - this.Bot.X), 2) + Math.Pow((this.Top.Y - this.Bot.Y), 2) + Math.Pow((this.Top.Z - this.Bot.Z), 2));

            return Math.PI * this.Radius * this.Radius * height;
        }

        public double GetArea()
        {
            double height = Math.Sqrt(Math.Pow((this.Top.X - this.Bot.X), 2) + Math.Pow((this.Top.Y - this.Bot.Y), 2) + Math.Pow((this.Top.Z - this.Bot.Z), 2));
            double circlesArea = 2 * Math.PI * this.Radius * this.Radius;
            double sideArea = 2 * Math.PI * this.Radius * height;
            return circlesArea + sideArea;
        }
        public override double GetPrimaryMeasure()
        {
            return GetVolume();
        }
    }
}