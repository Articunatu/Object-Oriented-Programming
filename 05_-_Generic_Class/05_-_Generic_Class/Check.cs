
namespace _05___Generic_Class
{
    public class Check<Unknown>
    {
        public bool ToCheck(Unknown firstVar, Unknown secondVar)
        {
            bool _toCheck = firstVar.Equals(secondVar); //Simplified ternary operator
            return _toCheck;
        }
    }

    public class Film<Unknown> : Check<Unknown>
    {

    }

    public class TVSeries<Unknown> : Check<Unknown>
    {

    }
}