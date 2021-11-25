
namespace TypesOfClasses_Tutorial
{
    public partial class PartialStudent
    {
        private string firstName, lastName;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
    }

    public partial class PartialStudent
    {
        public string GetFullName()
        {
            return firstName + " " + lastName;
        }
    }
}
