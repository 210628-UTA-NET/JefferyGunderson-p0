using System;

namespace SAModels
{
    public class StoreFront
    {
        public StoreFront() { }
        public StoreFront(string Name, string Address)
        {
            this.Name = Name;
            this.Address = Address;
        }
        public string Name { get; set; }
        public string Address { get; set; }
        public string[] Inventory { get; set; }
        public string[] ListofOrders { get; set; }

        public override string ToString()
        {
            return $"Name: {Name},\n Address: {Address}\n";
        }
    }

}