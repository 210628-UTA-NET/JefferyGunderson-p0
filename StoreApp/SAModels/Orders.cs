using System;

namespace SAModels
{
    public class Orders
    {

        protected int Order_Id
        {
            get
            {
                return Order_Id;
            }
        }
        protected string[] LineItems { get; set; }
        protected string[] OrderLineItems { get; set; }
        protected string Location { get; set; }
        protected decimal Price
        {
            get
            {
                return Price;
            }
        }
    }
}