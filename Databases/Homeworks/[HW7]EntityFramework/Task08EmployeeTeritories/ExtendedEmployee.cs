namespace Task08EmployeeTeritories
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Core.Metadata.Edm;
    using System.Data.Linq;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Task01ConnectToNorthwind;

    public class ExtendedEmployee<T> : Employee
    {
        private readonly EntitySet<Territory> entityTerritories;

        public EntitySet<Territory> EntityTerritories
        {
            get
            {
                var employeeTerritories = this.Territories;
                var entityTerritories = new EntitySet<Territory>();

                entityTerritories.AddRange(employeeTerritories);
                return entityTerritories;
            }
        }
    }
}