using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<Y, İ>
    {

        Y[] Yemek;
        İ[] İl;

        public MyDictionary()
        {
            Yemek = new Y[0];
            İl = new İ[0];

        }

        public void Add(Y key, İ item)
        {
            Y[] tempKeyArray = Yemek;
            İ[] tempValueArray = İl;

            Yemek = new Y[Yemek.Length + 1];
            İl = new İ[İl.Length + 1];

            for (int i = 0; i < tempKeyArray.Length; i++)
            {
                Yemek[i] = tempKeyArray[i];
                İl[i] = tempValueArray[i];

            }

            Yemek[Yemek.Length - 1] = key;
            İl[İl.Length - 1] = item;

        }
        public void List()
        {
            for (int i = 0; i < Yemek.Length; i++)
            {
                Console.WriteLine("İl: " + İl[i] + " Yemek: " + Yemek[i]);

            }
        }
    }
}
