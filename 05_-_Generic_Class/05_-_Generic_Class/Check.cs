
namespace _05___Generic_Class
{
    public class Check<Unknown>
    {
        public bool ToCheck(Unknown firstVar, Unknown secondVar)
        {
            
            if (firstVar.Equals(secondVar))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class Film<Unknown> : Check<Unknown>
    {

    }

    public class TVSeries<Unknown> : Check<Unknown>
    {

    }
}
