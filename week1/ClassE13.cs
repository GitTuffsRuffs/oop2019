using System;
using System.Collections.Generic;
using System.Text;

namespace oop19
{
    class ClassE13
    {
        List<int> bag = new List<int>();
        Random random;
        int pices;
        int prioMax;

        //Constructorn make list
        public ClassE13(int pices, int prioMax)
        {
            FillBag();
            random = new Random();
            this.pices = pices;
            this.prioMax = prioMax;
        }

        public void FillBag()
        {
            for (int i = 1; i <= pices; i++)
            {
                bag.Add(i);
            }
        }

        //Generate pice method
        public int GenerateNewPice()
        {
            int rand;

            //cheek if bag is empty
            if (bag.Count < 1)
            {
                FillBag();
            }

            //Cheek if bag is "new"
            if (bag.Count >= pices)
            {
                //Random 1-4
                rand = random.Next(1,prioMax+1);
                bag.Remove(rand);
                return rand;
            }
            else
            {
                //Bag not new, generate random pice.
                do
                {
                    rand = random.Next(1, pices+1);

                } while (bag.IndexOf(rand) < 0);

                bag.Remove(rand);
                return rand;
            }
        }
    }
}
