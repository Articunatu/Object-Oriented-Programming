using System;

namespace AssemblerA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Trainer
    {
        private int id;
        protected int ID { get { return id; } set { id = value; } }

    }

    class GymLeader : Trainer
    {
        public void Printer()
        {
            //GymLeader gl = new GymLeader();
            //Console.WriteLine(gl.id);

            this.ID = 100;
            base.ID = 101;
        }
  
    }
}
