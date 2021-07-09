using System;

namespace SAModels
{
    public class Orders
    {
        protected string[] OrderLineItems { get; set; }
        protected string Location { get; set; }
        protected double Price { get; set; }
    }
}