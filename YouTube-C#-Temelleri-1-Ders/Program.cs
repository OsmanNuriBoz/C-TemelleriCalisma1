using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTube_C__Temelleri_1_Ders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            accountsvariables();

            accounts accountsnew =new accounts();

            Console.ReadLine();
        }

        private static void accountsvariables()
        {
            string message = "Selamlar";
            double money = 1000000;
            int integer = 100;
            bool inputsuccess = true;

            string username = "Osman Nuri";
            string surname = "Boz";
            int birth = 2005;
            long republicnumber = 11111111111;

            Console.WriteLine(message);
            Console.WriteLine(money * 1.18);
            Console.WriteLine(integer);
            Console.WriteLine(inputsuccess);
        }
    }

    public class accounts
    {
        public string Username { get; set; }
        public string Surname { get; set; }
        public int Birth { get; set; }
        public long Republicnumber { get; set; }
    }
}