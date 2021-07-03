using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClotheShop_MVC.Models
{
    public class Clothes
    {

        [Key]
        public int ProductID { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [Range(20, 300)]
        public int Price { get; set; }
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        public string Image { get; set; }
        public string Sex { get; set; }
        public int TypeID { get; set; }
        public virtual ICollection<ShoppingCarts> ShoppingCarts { get; set; }

    }
}