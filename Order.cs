using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Decor_Sentsova
{
    public class Order
    {
        public string ProductArticleNumber { get; set; }
        public string ProductName { get; set; }
        public string ProductCost { get; set; }
        public string ProductManufacturer { get; set; }
        public string ProductCategory { get; set; }
        public string ProductDiscountAmount { get; set; }
        public string ProductDescription { get; set; }
        public string ProductCostWithDiscount { get; set; }
        public string ProductPhoto { get; set; }
        public static string OrderPickUpPoint { get; set; }
        public static DateTime OrderDate { get; set; }
        public static string OrderCode { get; set; }
        public Order() { }
        public Order(string productArticleNumber, 
            string productName, 
            string productCost, 
            string productManufacturer, 
            string productCategory, 
            string productDiscountAmount, 
            string productDescription, 
            string productCostWithDiscount, 
            string productPhoto)
        {
            ProductArticleNumber = productArticleNumber;
            ProductName = productName;
            ProductCost = productCost;
            ProductManufacturer = productManufacturer;
            ProductCategory = productCategory;
            ProductDiscountAmount = productDiscountAmount;
            ProductDescription = productDescription;
            ProductCostWithDiscount = productCostWithDiscount;
            ProductPhoto = productPhoto;
        }
    }
}
