using System;
using System.Collections.Generic;
using System.Text;

namespace WebStore
{
    internal class User
    {
        private int id; 
        private string name;
        private string surname;
        private string email;
        private string password;
        private string telephone;
        private string address;
        private string dni;
        private List<Product> wishlist;
        private List<Order> orders;
        private List<Review> reviews;


        public int Id
        {
            get { return id; }
            set { id = value; } 
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public List<Product> Wishlist
        {
            get { return wishlist; }
            set { wishlist = value; }
        }

        public List<Order> Orders
        {
            get { return orders; }
            set { orders = value; }
        }

        public List<Review> Reviews
        {
            get { return reviews; }
            set { reviews = value; }
        }

        public User(int id, string name, string surname, string email, string password, string telephone, string address, string dni, List<Product> wishlist, List<Order> orders, List<Review> reviews)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.email = email;
            this.password = password;
            this.telephone = telephone;
            this.address = address; 
            this.dni = dni;
            this.wishlist = new List<Product>();
            this.orders = new List<Order>();
            this.reviews = new List<Review>();
            
        }


        //Methods
        public void AddReview(Review review)
        {
            this.reviews.Add(review);
        }

        public void RemoveReview(Review review)
        {
            this.reviews.Remove(review);
        }

        public void AddOrder(Order order)
        {
            this.orders.Add(order);
        }

        public void RemoveOrder(Order order)
        {
            this.orders.Remove(order);
        }

        public void AddProduct(Product product)
        {
            this.wishlist.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            this.wishlist.Remove(product);
        }

        public List<Order> GetOrderHistory()
        {
            return this.orders;
        }

        public List<Review> GetReviews()
        {
            return this.reviews;
        }

        public void EditReview(Review review, int newRating, string newComment)
        {
            int index = this.reviews.IndexOf(review);
            if (index < 0)
            {
                return;
            }
            else
            {
                this.reviews[index].Rating = newRating;
                this.reviews[index].Comment = newComment;
            }
        }

    }

}
