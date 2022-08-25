using System;
using System.Collections.Generic;
using System.Text;

namespace DTS_NET.Abstract
{
    public abstract class MakhlukHidup
    {
        public string Bernafas()
        {
            return "menggunakan alat Pernapasan";
        }
        public abstract string BerkembangBiak();
        public virtual void Display()
        {
            Console.WriteLine("Klasifikasi Makhluk Hidup");
        }

        public void Hidup(string makhluk, string alam1)
        {
            Console.WriteLine(makhluk + " hidup di 1 alam yaitu : " + alam1);
        }

        public void Hidup(string makhluk, string alam1, string alam2)
        {
            Console.WriteLine(makhluk + " hidup di 2 alam yaitu : " + alam1 + " dan " + alam2);
        }
    }
}
