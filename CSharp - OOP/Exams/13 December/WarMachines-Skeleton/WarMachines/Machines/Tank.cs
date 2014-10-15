using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarMachines.Interfaces;

namespace WarMachines.Machines
{
    class Tank : Machine, ITank
    {
        private bool defenseMode;

        public Tank(string name, double attackPoints, double defensePoints) : base(name, null, 100, attackPoints, defensePoints)
        {
            this.defenseMode = false;
            ToggleDefenseMode();
        }

        public bool DefenseMode
        {
            get
            {
                return this.defenseMode;
            }
            private set
            {
                this.defenseMode = value;
            }
        }

        public void ToggleDefenseMode()
        {
            if (this.DefenseMode)
            {
                this.DefensePoints -= 30;
                this.AttackPoints += 40;
                this.DefenseMode = false;
            }
            else
            {
                this.DefensePoints += 30;
                this.AttackPoints -= 40;
                this.DefenseMode = true;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder(base.ToString());
            if (this.DefenseMode)
            {
                result.Append(" *Defense: ON");
            }
            else
            {
                result.Append(" *Defense: OFF");
            }
            return result.ToString();
        }
    }
}