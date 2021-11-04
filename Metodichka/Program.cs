using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodichka
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task Bank
            BankAccount snejanna = new BankAccount();
            BankAccount kleo = new BankAccount(12.5m);
            BankAccount mark = new BankAccount(0);
            BankAccount alisher = new BankAccount(1, 500m);
            snejanna.GetInfo();
            kleo.GetInfo();
            mark.GetInfo();
            alisher.GetInfo();
            mark.AddMoney(100m);
            mark.TakeFrom(alisher, 300);
            kleo.TakeFrom(mark, 10);
            mark.Dispose("mark.txt");
            //Task Song
            Song mySong = new Song();
            Console.WriteLine("\n"+mySong.Title()); 
        }
    }
}
