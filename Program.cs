using System;
using LIB;
using PD5.CSMS;

namespace OOPS
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Repository<Item> items = new("./PD5/CSMS/DB/");
            items.Show();
        }
    }
}