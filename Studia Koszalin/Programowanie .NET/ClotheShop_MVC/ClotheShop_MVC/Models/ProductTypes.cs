using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClotheShop_MVC.Models
{
    public class ProductTypes
    {
        [Key]
        public int TypeID { get; set; }
        [StringLength(25)]
        public string Name { get; set; }
        public string Image { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }
        public virtual ICollection<Clothes> Clothes { get; set; }
    }
}