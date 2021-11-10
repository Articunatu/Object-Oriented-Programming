using System;

namespace Encapsul
{
    class Customer
    {
        private int id;
        private string eMail, firstName, lastName;

        public string EMail
        {
            get
            {
                if (string.IsNullOrEmpty(eMail))
                {
                    return "Tom e-post";
                }

                return eMail;
            }
            set
            {
                eMail = value;
            }
        }

        public string FirstName
        {
            get
            {
                if (string.IsNullOrEmpty(firstName))
                {
                    return "Inget förstanamn";
                }

                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                if (string.IsNullOrEmpty(lastName))
                {
                    return "Inget efternamn";
                }

                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public int ID
        {
            get
            {
                if (id < 0)
                {
                    throw new Exception("Ogilitigt ID");
                }
                else
                {
                    return id;
                }               
            }
            set
            {
                id = value;
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine(EMail + "\n" +
                FirstName + "\n" +
                LastName + "\n" +
                ID);
        }

        public Customer(string eMail, string firstName, string lastName, int id)
        {
            EMail = eMail;
            FirstName = firstName;
            LastName = lastName;
            ID = id;
        }

        public Customer()
        {

        }
    }
}
