using System;
using System.Collections.Generic;
using System.Text;

namespace WebStore
{
    internal class Product
    {
        private int productId;
        private string productName;
        private string brand;
        private string image;
        private string description;
        private double price;
        private double discount; 
        private Category category;
        private Subcategory subcategory;
        private List<Label> labels;
        private List<Review> productReviews;
        


        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }
        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        public string Brand
        {
            get { return brand; }
            set
            {
                brand = value;
            }
        }
        public string Image
        {
            get { return image; }
            set
            {
                image = value;
            }
        }

        public string Description
        {
            get { return description; }
            set
            {
                description = value;
            }
        }

        public double Price
        {
            get { return price; }
            set
            {
                price = value;
            }
        }

        public double Discount
        {
            get { return discount; }
            set
            {
                discount = value;
            }
        }


        public Category Category
        {
            get { return category; }
            set
            {
                category = value;
            }
        }

        public Subcategory Subcategory
        {
            get { return subcategory; }
            set { subcategory = value; }
        }

        public List<Label> Labels
        {
            get { return labels; }
            set { labels = value; }
        }

        public List<Review> ProductReviews
        {
            get { return productReviews; }
            set { productReviews = value; }
        }

        public Product(int productId, string productName, string brand, string image, string description, double price, double discount, Category category, Subcategory subcategory, List<Label> labels, List<Review> productReviews)
        {
            this.productId = productId;
            this.productName = productName;
            this.brand = brand;
            this.image = image;
            this.description = description;
            this.price = price;
            this.discount = discount; 
            this.category = category;
            this.subcategory = subcategory;
            this.labels = new List<Label>();
            this.productReviews = new List<Review>();

        }

        public void AddLabel(Label label)
        {
            labels.Add(label);
        }
        public void RemoveLabel(Label label)
        {
            labels.Remove(label);
        }
        public double CalculateDiscountedPrice()
        {
            double discountedPrice = price - (price * discount);
            return discountedPrice;
        }

        public void ChangeCategory(Category newCategory)
        {
            this.category = newCategory;
        }

        public void ChangeSubcategory(Subcategory newSubcategory)
        {
            this.subcategory = newSubcategory;
        }
    }
}