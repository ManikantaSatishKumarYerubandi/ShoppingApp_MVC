using Microsoft.AspNetCore.Mvc;

namespace ShoppingApp_MVC.Models
{
    public class ProductDetails
    {
        public int productId { get; set; }

        public string productName { get; set; }

        public string productDescription { get; set; }
        public int productPrice { get; set; }

        public bool productIsInStock { get; set; }


        static List<ProductDetails> pList = new List<ProductDetails>()
        {
            new ProductDetails() {productId=101,productName="Pepse",productDescription="Cold-Drink",productIsInStock=true,productPrice=200},
            new ProductDetails() {productId=102,productName="Iphone",productDescription="Smart Phone",productIsInStock=false,productPrice=40000},
            new ProductDetails() {productId=103,productName="Appy",productDescription="Cold-Drink",productIsInStock=true,productPrice=200},
            new ProductDetails() {productId=104,productName="Orange",productDescription="Cold-Drink",productIsInStock=false,productPrice=400},
            new ProductDetails() {productId=105,productName="Laptop",productDescription="Electronic",productIsInStock=true,productPrice=50000},
        };

        public List<ProductDetails> GetProductAll()
        {
            return pList;
        }
    }
}
