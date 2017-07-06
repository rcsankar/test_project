using System;

namespace calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            if (args.Length < 1 || args.Length > 2)
            {
                Console.WriteLine("Argument Mismatched !!");
                Console.WriteLine("Format: Calculator sum 50,30");
            }
            else if (args.Length < 2)
            {
                if ((args[0]).ToUpper() != "SUM")
                {
                    Console.WriteLine("The first argument must be SUM");
                }
                else
                    Console.WriteLine("Summation = 0");
            }
            else 
            {
                try
                {
                    ICalculator worker = new Functions();
                    int result = worker.Sum(args[1]);

                    Console.WriteLine(string.Format("Result of the Summation = {0}", result));

                }
                catch (Exception e)
                {
                    Console.WriteLine("Error occurs: " + e.Message);
                }

            }
            

            Console.ReadLine();
        }
    }

    /// <summary>
    /// interface declare
    /// </summary>
    public interface ICalculator
    {
        int Sum(string arg);
    }


    public class Functions : ICalculator
    {
        public int Sum(string arg)
        {
            int result = 0;

            if (!string.IsNullOrEmpty(arg))
            {
                if(! arg.Contains(","))
                {
                    Console.WriteLine(arg);

                    int intval = 0;
                    if (int.TryParse(arg, out intval))
                    {
                        result = intval;
                    }
                    else
                        throw new Exception("Please provide numeric values");
                }
                else
                {
                    string[] numArray = arg.Split(',');
                    int intval = 0;

                    if (numArray.Length > 2)
                        throw new Exception("Please provide max of 2 values for summation");

                    for (int i = 0; i < numArray.Length; i++)
                    {
                        Console.WriteLine(numArray[i]);

                        intval = 0;
                        if (int.TryParse(numArray[i], out intval))
                        {
                            result += intval;
                        }
                        else
                            throw new Exception("Please provide numeric values");
                    }
                }

            }

            return result;

            //return int.Parse(arg);
        }
    }

}
