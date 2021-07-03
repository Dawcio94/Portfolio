using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarService.Models
{
    public class Dashboard
    {
        public List<Car> Cars { get; set; }
        public List<Address> Addresses { get; set; }
    }
}