using System;

namespace UnderstandingScope
{
    class Program
    {
        static void Main(string[] args)
        {
            string j = "";
            for (int i = 0; i < 10; i++)
            {
                j = i.ToString();
                Console.WriteLine(i);
            }
            //Console.WriteLine(i);    --error obtained since i is out of its code block

            Console.WriteLine(j);      //--i can now be accessed

            Console.ReadKey();

            Car MyCar = new Car();
          //MyCar.GetCarNumber;         --Only the public method can be accessed int his class
        }
    }
    class Car
    {
        private void HelperMethod()
        {
            Console.WriteLine("I am the helper method");
        }
        public void GetCarNumber()
        {
            Console.WriteLine("I am a public method");
        }

    }
}
