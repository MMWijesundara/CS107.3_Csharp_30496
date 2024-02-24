using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labsheet3_que3
{
    internal class Product
    {
        private int productId;
        private string productName;
        private double price;
        private int quantityInStock;

        

        public Product(int _productId , string _productName , double _price , int _quantityStock)
        {
            ProductId = _productId;
            productName = _productName;
            price = _price;
            quantityInStock = _quantityStock;
        }

        public int ProductId { get => productId; set => productId = value; }

        public void AddProduct()
        {

        }


    }
}
