using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut.Models
{
    public class Itemm
    {
        // makes new entity has increamented id 
        [Key]
        public int id { get; set; }
        [Required]
        public string Borrower { get; set; }
        [Required]
        public string lender{ get; set; }
        //this is how the itemmName is going to look like 
        [DisplayName("Item Name")]
        [Required]
        public string ItemmName { get; set; }
    }
}
