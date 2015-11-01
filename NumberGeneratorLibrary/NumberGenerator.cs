using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGeneratorLibrary
{
    public class NumberGenerator
    {
        public IEnumerable<string> GenerateNumbers(int startNum, int endNum, Tuple<int, string>[] tuples)
        {
            var sb = new StringBuilder();

            for (int i = startNum; i <= endNum; i++)
            {
                sb.Clear();
                sb.Append(i + " ");

                foreach (var tuple in tuples)
                {
                    if (i % tuple.Item1 == 0)
                    {
                        sb.Append(tuple.Item2 + " ");
                    }
                }

                yield return sb.ToString();
            }
        }

    }
}
