using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskConsoleApp
{
    public class Product
    {
        #region Fields
        public int count;
        public double price;
        public string name;
        public int number;
        #endregion

        public Product(string name, int number, double price)
        {
            this.name = name;
            this.number = number;
            this.price = price;
        }

        public override string ToString()
        {
            return $"Məhsulun adı: {name}\n" +
                $"Məhsulun nömrəsi: {number}\n" +
                $"Məhsulun sayı: {count}\n" +
                $"Məhsulun qiymeti: {price} ";
        }

    }
}
