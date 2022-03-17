using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Product
    {
        #region Fields
        int count;
        double price;        
        #endregion

        public Product(int count, double price)
        {
            this.count = count;
            this.price = price;
        }
        
        public override string ToString()
        {
            return $"Mehsulun sayi: {count}\n" +
                $"Mehsulun qiymeti: {price} "; 
        }

    }
}
