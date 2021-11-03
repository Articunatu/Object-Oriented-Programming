using System;

namespace AdvancedClasses
{
    interface IStudent
    {
        void Print(string name);
        void Cal(int num);
        void PrintInfo();
        void Search();
    }

    class Student : IStudent
    {
        public void Cal(int num)
        {
            throw new NotImplementedException();
        }

        public void Print(string name)
        {
            throw new NotImplementedException();
        }

        public void PrintInfo()
        {
            throw new NotImplementedException();
        }

        public void Search()
        {
            throw new NotImplementedException();
        }
    }
}
