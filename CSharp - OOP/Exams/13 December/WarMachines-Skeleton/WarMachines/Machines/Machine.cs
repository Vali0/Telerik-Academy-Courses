using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarMachines.Interfaces;

namespace WarMachines.Machines
{
    class Machine : IMachine
    {
        private string name;
        private IPilot pilot;
        private double healthPoints, attackPoints, defensePoints;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Wrong machine name. Null or empty");
                }
                this.name = value;
            }
        }

        public IPilot Pilot
        {
            get
            {
                return this.pilot;
            }
            set
            {
                this.pilot = value;
            }
        }

        public double HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Negative health points");
                }
                this.healthPoints = value;
            }
        }

        public double AttackPoints
        {
            get
            {
                return this.attackPoints;
            }
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Negative or zero attack points");
                }
                this.attackPoints = value;
            }
        }

        public double DefensePoints
        {
            get
            {
                return this.defensePoints;
            }
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Negative or zero defense points");
                }
                this.defensePoints = value;
            }
        }

        IList<string> targets;

        public Machine(string name, IPilot pilot, double health, double attack, double defense)
        {
            this.Name = name;
            this.Pilot = pilot;
            this.HealthPoints = health;
            this.AttackPoints = attack;
            this.DefensePoints = defense;
            targets = new List<string>();
        }

        public IList<string> Targets
        {
            get
            {
                return this.targets;
            }
        }

        public void Attack(string target)
        {
            this.targets.Add(target);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(" *Targets: ");
            if (targets.Count > 0)
            {
                foreach (var item in Targets)
                {
                    result.AppendFormat("{0}, ", item);
                }
                result.Length -= 2;
            }
            else
            {
                result.Append("None");
            }
            result.AppendLine();
            return result.ToString();
        }
    }
}