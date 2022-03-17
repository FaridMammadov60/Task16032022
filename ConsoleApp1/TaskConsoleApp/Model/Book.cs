using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskConsoleApp.Model
{
    public class Book:Product
    {
        #region Fields
        public string genre;
        #endregion
        #region Construction
        public Book(string genre, string name, int number, double price):base(name,number,price)
        {
            this.genre = genre;
        }
        #endregion
    }
}
