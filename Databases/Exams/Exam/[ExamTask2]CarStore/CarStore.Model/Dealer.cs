namespace CarStore.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Dealer
    {
        private ICollection<City> cities;

        private ICollection<Car> cars;

        public Dealer()
        {
            this.cars = new HashSet<Car>();
            this.cities = new HashSet<City>();
        }

        [Key]
        public int DealerId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public virtual City City { get; set; }

        public virtual ICollection<Car> Cars
        {
            get
            {
                return this.cars;
            }
            set
            {
                this.cars = value;
            }
        }
    }
}