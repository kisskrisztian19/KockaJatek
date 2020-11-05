using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KockaJatek
{
    
    class Dobas
    {
        int[] kocka = new int[5];
        public void EgyDobas()
        {
            Random vel = new Random();
            for (int i = 0; i < kocka.Length; i++)
            {
                kocka[i] = vel.Next(1, 7);
            }
        }
        public void Kiiras()
        {
            foreach (var i in kocka)
            {
                Console.Write($"{i} ");
            }
            Console.Write(":");
            
        }
        public string Erteke()
        {
            Dictionary<int, int> eredmeny = new Dictionary<int, int>();
            for (int i = 1; i <= 6; i++)
            {
                eredmeny.Add(i, 0);
            }
            foreach (var k in kocka)
            {
                eredmeny[k]++;
            }

            int par = 0;
            int sor = 0;
            for (int i = 1; i < eredmeny.Count+1; i++)
            {
                if (eredmeny[i] == 2)
                {
                    par++;
                }
                if (eredmeny[i] == 1)
                {
                    sor++;
                }
            }

            if (par == 1 && !eredmeny.ContainsValue(3))
            {
                return " pár";
            }
            else if (par == 2)
            {
                return " 2 pár";
            }
            else if (eredmeny.ContainsValue(2) && eredmeny.ContainsValue(3))
            {
                return " full";
            }
            else if (eredmeny.ContainsValue(3))
            {
                return " drill";
            }
            else if (eredmeny.ContainsValue(4))
            {
                return " póker";
            }
            else if (eredmeny.ContainsValue(5))
            {
                return " nagypóker";
            }
            else if (sor == 5 && eredmeny[1] == 0)
            {
                return " nagy sor";
            }
            else if (sor == 5 && eredmeny[6] == 0)
            {
                return " kis sor";
            }
            else return " szemét";

            
        }
    }
    
}

/*
 * ********************* Órai munka *********************
 * 
 * A dic-ből lekérdezzük az 1 Value-nál nagyobb elemeket
 * Első eset ha egy elem marad (Value értéket nézzük):
 * * 5 Nagypóker
 * * 4 Póker
 *  * ...
 * A key érték mondja meg, hogy hányas: 4 póker
 * Második eset két elem marad:
 *  * 3 és 2 az Full
 *  * 2 és 2 az két pár
 *  Harmadik ha nem marad egy sem:
 *  * Key[6] == 0 Kissor
 *  * Key[1] == 0 Nagysor
 *  Minden más esetben moslék
 *  var result = from e in eredmeny
 *               where e.Value > 1
 *               select new {Szam=e.Key, Db=e.Value};
 * foreach ezután, stb...
 *  
 *  (A fenti saját)
 */
