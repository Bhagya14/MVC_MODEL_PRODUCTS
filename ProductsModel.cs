using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC_Model_Products.Models
{
    public class ProductsModel
    {
        [Display(Name = "Product ID")]
        public int productid { get; set; }

        [Display(Name = "Product Name")]
        [Required(ErrorMessage = "*")]
        public string productname { get; set; }

        [Display(Name = "Product Price")]
        [Required(ErrorMessage = "*")]
        public int productprice { get; set; }

        [Display(Name = "Product Category")]
        [Required(ErrorMessage = "*")]
        public string productcategory { get; set; }
        public string productimageaddress { get; set; }

        [Display(Name = "Product Image")]
        [Required(ErrorMessage = "*")]
        public HttpPostedFileBase productimagefile { get; set; }

    }
}