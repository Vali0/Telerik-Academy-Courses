using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyGeometry
{
    class Circle : Figure, IFlat, IAreaMeasurable
    {
        public double Radius { get; private set; }

        public Circle(Vector3D a, double radius) : base(a)
        {
            this.Radius = radius;
        }

        public Vector3D GetNormal()
        {
            Vector3D center = this.GetCenter();
            Vector3D B = new Vector3D(center.X + this.Radius, center.Y, center.Z);
            Vector3D C = new Vector3D(center.X, center.Y + this.Radius, center.Z);

            Vector3D normal = Vector3D.CrossProduct(B - center, C - center);
            normal.Normalize();
            return normal;
            
        }

        public double GetArea()
        {
            return Math.PI * this.Radius * this.Radius;
        }

        public override double GetPrimaryMeasure()
        {
            return GetArea();
        }
    }
}