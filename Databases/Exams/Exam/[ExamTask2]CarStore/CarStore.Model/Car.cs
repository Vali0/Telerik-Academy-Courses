namespace CarStore.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Car
    {
        [Key]
        public int CarId { get; set; }

        [Required]
        [StringLength(20)]
        public string Model { get; set; }

        [Required]
        public DateTime Year { get; set; }

        [Required]
        public decimal Price { get; set; }

        public string Transmission { get; set; }

        public virtual Manufacturer Manufacturer { get; set; }

        public virtual Dealer Dealer { get; set; }
    }
}