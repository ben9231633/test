using System;
using System.Linq;

namespace coredb
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            var db = new testdbContext();
            var q = from p in db.AddressBook
                    select p;
            foreach(var item in q){
                Console.WriteLine($"{item.CName}-{item.Tel}-{item.Address}");
            }
        }
    }
}
