using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace MVC_Model_Products.Models
{
    public class ProductProjectionModel
    {
        [Display(Name = "Product id")]
        public int productid { get; set; }
        [Display(Name = "Product name")]
        public string productname { get; set; }

        [Display(Name = "Product category")]
        public string productcategory { get; set; }

        [Display(Name = "Product image")]
        public string productimageaddress { get; set; }
    }
}