using DTS_NET.Abstract;
using DTS_NET.Object;
using System;
using System.Collections.Generic;
using System.Text;

// Object Oriented Programming
// 1. Inheritance
// 2. Encapsulation
// 3. Polimorphism
// -> override -> abstract & virtual -> Reference type, Nama Behaviour/Method, dan Parameter (SAMA)
// -> overload -> Reference type dan Nama Behaviour/Method (SAMA)

namespace DTS_NET.OOP
{
    public class Main
    {
        public void Display()
        {
            Manusia manusia = new Manusia("Beranak");
            manusia.Display();
            Console.WriteLine("Manusia bernafas " + manusia.Bernafas());
            Console.WriteLine("Manusia " + manusia.BerkembangBiak());
            manusia.Hidup("Manusia", "Daratan");

            Console.WriteLine();

            Burung burung = new Burung("Bertelur");
            burung.Display();
            Console.WriteLine("Burung bernafas " + burung.Bernafas());
            Console.WriteLine("Burung " + burung.BerkembangBiak());
            burung.Hidup("Burung", "Daratan");
        }
    }
}
