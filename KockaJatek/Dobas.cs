using System;
using System.Collections.Generic;

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

        /* private string eredmeny;
         public string Eredmeny { get 
             {
                 return eredmeny;
             }
         }*/

        /*public Dobas(int k1, int k2, int k3, int k4, int k5)
        {
            kocka[0] = k1;
            kocka[1] = k2;
            kocka[2] = k3;
            kocka[3] = k4;
            kocka[4] = k5;

            eredmeny = Erteke();
        }*/


        public void Kiiras()
        {
            foreach (var i in kocka)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine($": {Erteke()}");

            
            
        }
        private string Erteke()
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
 *  var result = (from e in eredmeny
 *               where e.Value > 1
 *               select new {Szam=e.Key, Db=e.Value}).ToList; *** A result ezután listaként funkcionál ***
 * CWL($"Darab: {result.Count}"); pl: 5,5,2,6,1-nél darab: 1 5:2(ez foreach)
 * string tömb alapján adunk vissza eredményt
 * 
 *  
 *  (A fenti saját)
 */
