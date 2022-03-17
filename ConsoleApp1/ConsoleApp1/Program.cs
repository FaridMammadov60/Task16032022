using ConsoleApp1.Models;
using System;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            #region Dersde yazilan
            int a = GetInputInt("Elave edilecek nootbook sayin daxil edin: ", 0);
            Nootbook[] nootbooks = new Nootbook[a];
            for (int i = 0; i < nootbooks.Length; i++)
            {
                string brandName = GetInputStr("Brand daxil edin: ", 1, 100);

                string model = GetInputStr("Model daxil edin: ", 1, 100);

                int ram = GetInputInt("Ram daxil edin: ", 1, 1000);

                int storage = GetInputInt("Yaddaş daxil edin: ", 1, 1000000);

                double price = GetInputdouble("Qiymət daxil edin: ", 1, 500000);

                int count = GetInputInt("Say daxil edin: ", 1, 100);
                Console.WriteLine("---------------------------");
                nootbooks[i] = new Nootbook(brandName, count, price)
                {
                    model = model,
                    ram = ram,
                    storage = storage,
                };



            }

            foreach (var item in nootbooks)
            {
                Console.WriteLine(item);
                Console.WriteLine("---------------------------");

            }
            #endregion

        }
        #region Dersde yazilan method
        static int GetInputInt(string name, int min, int max = int.MaxValue)
        {
            int input;
            do
            {
                Console.WriteLine(name);
                input = Convert.ToInt32(Console.ReadLine());
            } while (input < min || input > max);
            return input;
        }
        static string GetInputStr(string name, int min, int max = int.MaxValue)
        {
            string input;
            do
            {
                Console.WriteLine(name);
                input = Console.ReadLine();
            } while (input.Length < min || input.Length > max);
            return input;
        }
        static double GetInputdouble(string name, int min, int max = int.MaxValue)
        {
            double input;
            do
            {
                Console.WriteLine(name);
                input = Convert.ToDouble(Console.ReadLine());
            } while (input < min || input > max);
            return input;
        }
        #endregion

    }
}
