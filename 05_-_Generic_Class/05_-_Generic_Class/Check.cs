
namespace _05___Generic_Class
{
    public class Check<Unknown>
    {
        public bool ToCheck(Unknown firstVar, Unknown secondVar)
        {
            bool _toCheck = firstVar.Equals(secondVar) ? true : false;
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