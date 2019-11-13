using System;
using System.Collections.Generic;
using System.Text;

namespace oop19
{
    class ClassE13
    {
        List<int> bag = new List<int>();
        Random random;

        //Constructorn make list
        public ClassE13(int pices)
        {
            FillBag(pices);
            random = new Random();
        }

        public void FillBag(int pices)
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
                FillBag(7);
            }

            //Cheek if bag is "new"
            if (bag.Count > 6)
            {
                //Random 1-4
                rand = random.Next(1,5);
                bag.Remove(rand);
                return rand;
            }
            else
            {
                //Bag not new, generate random pice.
                do
                {
                    rand = random.Next(1, 8);

                } while (bag.IndexOf(rand) < 0);

                bag.Remove(rand);
                return rand;
            }
        }
    }
}
