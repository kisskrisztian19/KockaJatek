using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KockaJatek
{
    class Program
    {
        /*static void Ellenorzes()
        {
            System.IO.StreamReader olvas = new System.IO.StreamReader("teszt.txt");
            while (!olvas.EndOfStream)
            {
                string[] seged = new string[5];
                seged = olvas.ReadLine().Split(',');
                Dobas d = new Dobas(int.Parse(seged[0]), int.Parse(seged[1]), int.Parse(seged[2]), int.Parse(seged[3]), int.Parse(seged[4]));

                d.Kiiras();
            }
            olvas.Close();
        }*/
        static void Main(string[] args)
        {

            //Ellenorzes();

            Dobas gep = new Dobas();
            Dobas ember = new Dobas();

            gep.EgyDobas();
            gep.Kiiras();

            ember.EgyDobas();
            ember.Kiiras();

            Console.ReadKey();
        }
    }
}
