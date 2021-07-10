using System;
using System.Text.RegularExpressions;


namespace SAModels
{
    public class Customer
    {



        public int Customer_Id
        {
            get
            {
                return Customer_Id;
            }

        }
        public string Email
        {
            get
            {
                return Email;
            }
        }

        public string FirstName
        {
            get
            {
                return FirstName;
            }
            set
            {
                if (!Regex.IsMatch(value, @"^[A-Za-z .]+$"))
                {
                    throw new Exception("FirstName only holds letters.");
                }
                FirstName = value;
            }
        }
        public string AddressLine1
        {
            get
            {
                return AddressLine1;

            }


        }

        public string LastName
        {
            get
            {
                return LastName;
            }

            set
            {
                if (!Regex.IsMatch(value, @"^[A-Za-z .]+$"))
                {
                    throw new Exception("FirstName only holds letters.");
                }
                LastName = value;
            }

        }
        public string AddressLine2
        {
            get
            {
                return AddressLine1;

            }


        }
        public string City
        {
            get
            {
                return City;
            }

            set
            {
                if (!Regex.IsMatch(value, @"^[A-Za-z .]+$"))
                {
                    throw new Exception("FirstName only holds letters.");
                }
                City = value;
            }

        }
        public string State
        {
            get
            {
                return State;
            }

            set
            {
                if (!Regex.IsMatch(value, @"^[A-Za-z .]+$"))
                {
                    throw new Exception("FirstName only holds letters.");
                }
                State = value;
            }
        }














        //overrides default string function allowing you to output object parameters:: otherwise you receive "namespace.class"

        public override string ToString() => $" Customer_Id: {Customer_Id}\n FirstName: {FirstName}\n LastName: {LastName}\n AddressLine1: {AddressLine1}\n AddressLine2: {AddressLine2}\n City: {City} \n State: {State}\n Email: {Email}";

    }
}
