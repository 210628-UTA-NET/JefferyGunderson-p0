using System;

namespace SAModels
{
    public class LineItems
    {
        public int _LineItem_Id;




        public LineItems(string product, int quantity, int lineItem_Id)
        {
            this.Product = product;
            this.Quantity = quantity;

        }

        private string Product { get; set; }
        private int Quantity { get; set; }
    }
}