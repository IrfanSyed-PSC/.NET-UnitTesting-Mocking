using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleApp;

namespace SampleApp
{
    public class Program
    {

        static void Main(string[] args)
        {
        }


        public String printit(IAnimal animal)
        {
            Console.WriteLine($"animal name is {animal.Name()}");
            return animal.Name();
        }

        public String testme()
        {
            return "yo"; 
        }
    }
}
