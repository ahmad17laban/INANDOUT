using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut.Models
{
    public class Expence
    {
        [Key]
        public int id { get; set; }
        [DisplayName("Expence")]
        [Required]
        public string ExpenceName { get; set; }
        [Required]
        [Range(1,int.MaxValue,ErrorMessage ="Amount must be grater then 0")]
        public int Amount { get; set; }
    }
}
