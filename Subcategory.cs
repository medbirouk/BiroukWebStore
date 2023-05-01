using System;
using System.Collections.Generic;
using System.Text;

namespace WebStore
{
    internal class Subcategory
    {
        private int subcategoryId; 
        private string subcategoryName;
        private List<Product> subcategoryProducts; 


        public int SubcategoryId
        {
            get { return subcategoryId; }
            set { subcategoryId = value; }
        }

        public string SubcategoryName
        {
            get { return subcategoryName; }
            set { subcategoryName = value; }
        }

        public List<Product> SubcategoryProducts
        {
            get { return subcategoryProducts; }
            set
            {
                subcategoryProducts = value;
            }
                
        }

        public Subcategory(int subcategoryId, string subcategoryName, List<Product> subcategoryProducts)
        {
            SubcategoryId = subcategoryId;
            SubcategoryName = subcategoryName;
            SubcategoryProducts = new List<Product>();
            
        }

        public void AddProduct(Product product)
        {
            this.subcategoryProducts.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            this.subcategoryProducts.Remove(product);
        }
    }
}
