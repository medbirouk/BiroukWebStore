using System;
using System.Collections.Generic;
using System.Text;

namespace WebStore
{
    internal class Review
    {
        private int reviewId;
        private User user;
        private Product product;
        private int rating;
        private string comment;

        public int ReviewId
        {
            get { return reviewId; }
            set { reviewId = value; }
        }
        public User User
        {
            get { return user; }
            set { user = value; }
        } 

        public Product Product
        {
            get { return product; }
            set { product = value; }
        }

        public int Rating
        {
            get { return rating; }
            set { rating = value; }
        }

        public string Comment
        {
            get { return comment; }
            set
            {
                comment = value;
            }
        }

        public Review(int reviewId, User user, Product product, int rating, string comment)
        {
            this.reviewId = reviewId;
            this.user = user;
            this.product = product;
            this.rating = rating;
            this.comment = comment;
            
        }
    }
}
