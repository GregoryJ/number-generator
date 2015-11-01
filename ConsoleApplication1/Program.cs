using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumberGeneratorLibrary;

namespace ConsoleApplication1
{
    class Program
    {
        private static void Main(string[] args)
        {
            NumberGenerator numberGenerator = new NumberGenerator();

            var tuples = new Tuple<int, string>[]
            {
                new Tuple<int, string>(3, "snap"),
                new Tuple<int, string>(5, "crackle"),
                new Tuple<int, string>(7, "pop")
            };

            IEnumerable<string> numbers = numberGenerator.GenerateNumbers(1, 1000, tuples);

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
