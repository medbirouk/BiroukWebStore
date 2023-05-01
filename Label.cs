using System;
using System.Collections.Generic;
using System.Text;

namespace WebStore
{
    internal class Label
    {
        private int labelId;
        private string labelName;
        private List<Product> labelProducts; 
        
        public int LabelId
        {
            get { return labelId; }
            set { labelId = value; }
        }
        public string LabelName
        {
            get { return labelName; }
            set { labelName = value; }
        }
        public List<Product> LabelProducts
        {
            get { return labelProducts; }
            set { labelProducts = value; }
        }

        public Label(int labelId, string labelName, List<Product> labelProducts)
        {
            this.labelId = labelId;
            this.labelName = labelName;
            this.labelProducts = new List<Product>();
            
        }

        public void AddProduct(Product product)
        {
            this.labelProducts.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            this.labelProducts.Remove(product);
        }
    }
}
