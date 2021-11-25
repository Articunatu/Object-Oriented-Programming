
namespace TypesOfClasses_Tutorial
{
    public partial class PartialCustomer
    {
        private string firstName, lastName, gender, email;
        private int id, salary;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Email { get => email; set => email = value; }
        public int ID { get => id; set => id = value; }
        public int Salary { get => salary; set => salary = value; }
    }
}
