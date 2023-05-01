using System;
using System.Collections.Generic;
using System.Text;

namespace WebStore
{
    internal class Category
    {
        private int categoryId; 
        private string categoryName;
        private List<Product> categoryProducts;
        private List<Subcategory> subcategories;

        public int CategoryId
        {
            get { return categoryId; }
            set { categoryId = value; }
        }
        public string CategoryName
        {
            get { return categoryName; }
            set { categoryName = value; }
        }
        public List<Product> CategoryProducts
        {
            get { return categoryProducts; }
            set
            {
                categoryProducts = value;
            }

        }

        public List<Subcategory> Subcategories
        {
            get { return subcategories; }
            set { subcategories = value; }
        }

        public Category(int categoryId, string categoryName, List<Product> categoryProducts, List<Subcategory> subcategories)
        {
            CategoryId = categoryId;
            CategoryName = categoryName;
            CategoryProducts = new List<Product>();
            Subcategories = new List<Subcategory>();
        }

        public void AddProduct(Product product)
        {
            this.categoryProducts.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            this.categoryProducts.Remove(product);
        }

        public void AddSub(Subcategory subcategory)
        {
            this.subcategories.Add(subcategory);
        }

        public void RemoveSub(Subcategory subcategory)
        {
            this.subcategories.Remove(subcategory);
        }
    }
}
