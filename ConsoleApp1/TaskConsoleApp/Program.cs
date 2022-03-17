using System;
using System.Text;
using TaskConsoleApp.Model;

namespace TaskConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            #region AddMassiv
            int a = GetInputInt("Əlavə edilecek kitabların sayın daxil edin: ", 0, 2500);
            Book[] books = new Book[a];
            for (int i = 0; i < books.Length; i++)
            {
                string genre = GetInputStr("Kitabın janrın daxil edin: ", 1, 50);

                string name = GetInputStr("Kitabın adın daxil edin: ", 1, 100);

                int number = GetInputInt("Kitabın nömrəsin daxil edin: ", 1);

                double price = GetInputdouble("Kitabın qiymətin daxil edin: ", 1, 500);

                int count = GetInputInt("Kitabın sayı daxil edin: ", 1);
                Console.WriteLine("---------------------------");
                books[i] = new Book(genre, name, number, price)
                {
                    count = count
                };

            }
            #endregion

            #region Menyu1
            //Menyu1
            Console.Clear();
        L1: Console.WriteLine($"Kitabları qiymətlərə görə filtrləmək üçün 1\n" +
             $"Bütün kitabları göstərmək üçün 2\n" +
             $"Proqramı bağlamaq üçün 0 düyməsin sıxın");

            int xx = Convert.ToInt32(Console.ReadLine());

            if (xx > 3 || xx < 0)
            {
                goto L1;
            }


            switch (xx)
            {
                case 0:
                    return;
                case 1:
                    double temp;
                    for (int i = 0; i < books.Length; i++)
                    {
                        for (int j = i + 1; j < books.Length; j++)
                        {
                            if (books[i].price < books[j].price)
                            {
                                temp = books[i].price;
                                books[i].price = books[j].price;
                                books[j].price = temp;
                            }
                        }
                    }

                    foreach (var item in books)
                    {
                        Console.WriteLine(item);
                        Console.WriteLine("---------------------------");
                    }
                    break;
                case 2:
                    foreach (var item in books)
                    {
                        Console.WriteLine(item);
                        Console.WriteLine("---------------------------");
                    }
                    break;
                default:
                    goto L1;



            }
        #endregion

        #region Menyu2
        //menyu2
        L2: Console.WriteLine($"Kitabları verilmiş qiymət aralığına görə filtrəmək üçün 1\n" +
        $"Bütün kitabları göstərmək üçün 2\n" +
        $"Proqramı bağlamaq üçün 3 düyməsin sıxın");

            int yy = Convert.ToInt32(Console.ReadLine());

            if (yy > 3 || xx < 0)
            {
                goto L2;
            }

            switch (yy)
            {
                case 0:
                    return;
                case 1:
                    Console.WriteLine("Minumum dəyəri daxil edin: ");
                    double minValu = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Maksimum dəyəri daxil edin: ");
                    double maxValue = Convert.ToDouble(Console.ReadLine());
                    for (int i = 0; i < books.Length; i++)
                    {
                        if (books[i].price > minValu && books[i].price < maxValue)
                        {
                            Console.WriteLine(books[i]);
                            Console.WriteLine("----------------");
                        }
                    }
                    goto L2;
                case 2:
                    foreach (var item in books)
                    {
                        Console.WriteLine(item);
                        Console.WriteLine("---------------------------");
                    }
                    goto L2;
                default:
                    goto L2;




            }
            #endregion

        }

        #region Method


        /// <summary>
        /// Geriyə int dəyər qaytarır
        /// </summary>
        /// <param name="name">Nə istədiyimizi soruşur</param>
        /// <param name="min">minumum dəyər</param>
        /// <param name="max">maksimum dəyər</param>
        /// <returns></returns>
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


        /// <summary>
        /// Geriyə int dəyər qaytarır
        /// </summary>
        /// <param name="name">Nə istədiyimizi soruşur</param>
        /// <param name="min">minumum dəyər</param>
        /// <param name="max">maksimum dəyər</param>
        /// <returns></returns>
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
        /// <summary>
        /// Geriyə int dəyər qaytarır
        /// </summary>
        /// <param name="name">Nə istədiyimizi soruşur</param>
        /// <param name="min">minumum dəyər</param>
        /// <param name="max">maksimum dəyər</param>
        /// <returns></returns>
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
