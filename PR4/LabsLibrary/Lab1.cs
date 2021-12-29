using System;
using System.Collections.Generic;
using System.IO;

namespace LabsLibrary
{
    public class pr1
    {
        static void Main(string[] args)
        {
            StreamReader inp = new StreamReader("input.txt");
            StreamWriter outp = new StreamWriter("output.txt");
            try
            {
                long N = Int64.Parse(inp.ReadLine());
                if ((N >= 0) && (N < Math.Pow(10, 18)))
                    outp.Write(Calculate(N));
                else
                    outp.Write("Input value should be in range[0, 10^18]");
            }
            catch
            {
                outp.Write("Input numeric value");
            }
            outp.Close();
            Console.WriteLine("Done...");
        }

        public static int Calculate(long N)
        {
            if (N < 3) return 0;
            if (N == 3) return 1;
            if (N % 2 == 0) return 2 * Calculate(N / 2);
            var k = N / 2;
            return Calculate(k) + Calculate(k + 1);
        }
    }
}
