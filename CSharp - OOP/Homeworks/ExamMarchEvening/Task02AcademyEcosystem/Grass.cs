using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyEcosystem
{
    class Grass : Plant
    {
        public Grass(Point position) : base(position, 2)
        {
        }

        public override void Update(int time)
        {
            if (this.IsAlive && time != 0)
            {
                this.Size += time;
            }
        }
    }
}