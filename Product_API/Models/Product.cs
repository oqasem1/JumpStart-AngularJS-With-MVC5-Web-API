//Starting AngularJS With MVC Web API by Omar Al-Haj Qasem , 15 Sep 2014
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Product_API.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }


    }
}