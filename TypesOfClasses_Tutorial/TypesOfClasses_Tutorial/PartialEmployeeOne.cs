
namespace TypesOfClasses_Tutorial
{
    public partial class PartialEmployee
    {

        private string firstName, lastName, gender;
        private double salary;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
    }
}
