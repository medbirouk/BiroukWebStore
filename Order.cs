using System;
using System.Collections.Generic;
using System.Text;

namespace WebStore
{
    internal class Order
    {
        private int orderId;
        private DateTime orderDate;
        private List<Product> products;
        private int quantity;
        private double finalPrice;
        private User user;
        private bool isDelivered;
        private List<OrderItem> items; 


        public int OrderId
        {
            get { return orderId; }
            set { orderId = value; }

        }

        public DateTime OrderDate
        {
            get { return orderDate; }
            set { orderDate = value; }
        }

        public List<Product> Products
        {
            get { return products; }
            set { products = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public double FinalPrice
        {
            get { return finalPrice; }
            set { finalPrice = value; }
        }

        public User User
        {
            get { return user; }
            set { User = value; }
        }

        public bool IsDelivered
        {
            get { return isDelivered; }
            set { isDelivered = value; }
        }

        public List<OrderItem> Items
        {
            get { return items; }
            set { items = value; }
        }

        public Order(int orderId, DateTime orderDate, List<Product> products, int quantity, double finalPrice, User user, bool isDelivered, List<OrderItem> items)
        {
            this.orderId = orderId;
            this.orderDate = orderDate;
            this.FinalPrice = finalPrice;
            this.products = new List<Product>();
            this.user = user;
            this.IsDelivered = isDelivered;
            this.items = new List<OrderItem>(); 
        }

        //Methods 

        public void AddProduct(Product product, int quantity)
        {
            OrderItem item = new OrderItem(product, quantity);
            this.items.Add(item);
            this.finalPrice += product.Price * quantity;
        }

        public void RemoveProduct(int index)
        {
            if (index >= 0 && index < items.Count)
            {
                OrderItem item = items[index];
                this.finalPrice -= item.Product.Price * item.Quantity;
                items.RemoveAt(index);
            }
        }


        public void Deliver()
        {
            this.isDelivered = true;
        }

        public void CancelOrder()
        {
            this.user.Orders.Remove(this);
        }





        

    }
    class OrderItem
    {
        private Product product;
        private int quantity;

        public Product Product
        {
            get { return product; }
            set { product = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public OrderItem(Product product, int quantity)
        {
            this.product = product;
            this.quantity = quantity;
        }
    }
}
