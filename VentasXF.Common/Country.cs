using System;
using System.ComponentModel.DataAnnotations;
namespace VentasXF.Common
{
    public class Country
    {
        public int Id { get; set; }

        [MaxLength(50)]
        [Required]
        public string Name { get; set; }

    }
}
