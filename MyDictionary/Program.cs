using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> yemekler = new MyDictionary<string, string>();
            yemekler.Add("Çibörek", "Eskişehir");
            yemekler.Add("Tantuni", "Mersin");
            yemekler.Add("Mantı", "Kayseri");

            yemekler.List();

        }
    }
}
