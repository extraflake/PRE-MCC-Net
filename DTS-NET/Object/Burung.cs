using DTS_NET.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DTS_NET.Object
{
    class Burung : MakhlukHidup
    {
        public Burung(string Berkembang)
        {
            this.Berkembang = Berkembang;
        }

        public string Berkembang { get; private set; }

        public override string BerkembangBiak()
        {
            return "berkembang biak dengan cara " + Berkembang;
        }

        public override void Display()
        {
            Console.WriteLine("Burung");
        }
    }
}
