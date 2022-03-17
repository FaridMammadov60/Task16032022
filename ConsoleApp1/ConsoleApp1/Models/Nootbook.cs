using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Nootbook:Product
    {
        string brandName;
        public string model;
        public int ram;
        public int storage;


        public Nootbook(string brandName, int count, double price) :base(count,price)
        {
            this.brandName = brandName;
            
        }
       
        public override string ToString()
        {
            return $"Mehsulun adi: {brandName}\n" +
                $"Mehsulun modeli: {model}\n" +
                $"Mehsulun rami: {ram}\n" +
                $"Mehsulun saxlanmasi: {storage}";     
        }
    }
}
