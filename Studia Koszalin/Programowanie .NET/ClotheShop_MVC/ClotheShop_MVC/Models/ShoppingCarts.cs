using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClotheShop_MVC.Models
{
    public class ShoppingCarts
    {
        [Key]
        public int CartID { get; set; }
        public string ClientID { get; set; }
        public int ProductID { get; set; }
        public Int32? Amount { get; set; }
        [DataType(DataType.DateTime)]
        public string DatePurchased { get; set; }
        public string UserName { get; set; }
        public virtual ICollection<Clothes> Clothes { get; set; }
        
    }
    
}