namespace CarStore.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class City
    {
        [Key]
        public int CityId { get; set; }


        [Required]
        [Index(IsUnique = true)]
        [MaxLength(10)]
        public string Name { get; set; }
    }
}