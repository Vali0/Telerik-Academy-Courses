using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarMachines.Interfaces;

namespace WarMachines.Machines
{
    class Pilot : IPilot
    {
        private string name;
        readonly IList<IMachine> machines;

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
                    throw new ArgumentNullException("Wrong pilot name. Null or empty");
                }
                this.name = value;
            }
        }

        public Pilot(string name)
        {
            this.Name = name;
            machines = new List<IMachine>();
        }

        public void AddMachine(IMachine machine)
        {
            machines.Add(machine);
        }

        public string Report()
        {
            StringBuilder result = new StringBuilder();
            if (this.machines.Count == 0)
            {
                result.AppendFormat("{0} - no machines", this.Name);
            }
            else if (this.machines.Count == 1)
            {
                result.AppendFormat("{0} - 1 machine", this.Name);
            }
            else
            {
                result.AppendFormat("{0} - {1} machines", this.Name, this.machines.Count);
            }
            foreach (var item in machines)
            {
                result.AppendFormat("\n- {0}\n", item.Name);
                result.AppendFormat(" *Type: {0}\n", item.GetType().Name);
                result.AppendFormat(" *Health: {0}\n", item.HealthPoints);
                result.AppendFormat(" *Attack: {0}\n", item.AttackPoints);
                result.AppendFormat(" *Defense: {0}\n", item.DefensePoints);
                result.Append(item.ToString());
            }
            return result.ToString();
        }
    }
}