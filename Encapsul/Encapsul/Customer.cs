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

        //public string LastName
        //{
        //    get
        //    {
        //        if (string.IsNullOrEmpty(LastName))
        //        {
        //            throw new Exception("Inget efternamn");
        //        }
        //        else
        //        {
        //            return lastName;
        //        }
        //    }
        //    set
        //    {
        //        lastName = LastName;
        //    }
        //}

        //public string FirstName
        //{
        //    get
        //    {
        //        if (string.IsNullOrEmpty(FirstName))
        //        {
        //            return "No first name";
        //        }
        //        else
        //        {
        //            return firstName;
        //        }
        //    }
        //    set
        //    {
        //        firstName = FirstName;
        //    }
        //}

        //public int Id
        //{
        //    get
        //    {
        //        if (id < 0)
        //        {
        //            throw new Exception("Ogiltigt id");
        //        }
        //        else
        //        {
        //            return id;
        //        }
        //    }
        //    set
        //    {
        //        id = Id;
        //    }
        //}
    }
}
