using System;
using System.Collections.Generic;
using System.Linq;

namespace DTS_NET
{
    class Program
    {
        #region closing
        // Primitive Data Type
        // penyimpanan bilangan bulat -> int : Int32, short : Int16, long : Int64
        int valueInt = 1, valueIntWithoutValue;
        short valueShort = 1;
        long valueLong = 1;

        // penyimpanan bilangan pecahan -> double, float, decimal
        double valueDouble = 2.5D;
        float valueFloat = 2.5F;
        float valueFloat2 = (float) 2.5;
        decimal valueDecimal = 2.5M;
        decimal valueDecimal2 = (decimal) 2.5;

        // penyimpanan alphanumeric -> string, char
        string valueString = "abc123.~!";
        char valueChar = 'a';

        // penyimpanan true/false -> bool
        bool valueBool = true;
        bool valueBoolFalse = false;

        // Array -> kumpulan dari berbagai nilai yang memiliki tipe data yang sama
        int[] arrInt = new int[10];
        static int[] arrIntWithValue = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int[,] arrInt2D = new int[2, 1] { { 2 }, { 1 } };
        // int[,,] arrInt3D = new int[2, 1, 1] { { 2 }, { 1 },  };
        string[] arrString = new string[2] { "hello", "world" };

        // Looping -> perulangan yang melakukan perintah secara berulang sesuai dengan kondisi yang dimiliki
        // Do While
        // While Do
        // For
        // Foreach

        // Operator
        // Aritmatika -> +, ++, -, /, *, --, %
        // Assignment -> =, +=, -=, *=, /=
        // -> =+ -> nilai = nilai + 2;
        // -> -= -> nilai = nilai - 2;
        // Comparison -> <, <=, >=, >, ==, !=
        // Logical -> &&, ||, !

        // Method -> Behaviour
        // Void -> menampilkan data
        // Non-Void -> memproses data

        int Process()
        {
            int value1 = 2, value2 = 6, result;
            result = value1 + value2;
            return result;
        }

        double ProcessValueWithDouble()
        {
            double value1 = 2.5, value2 = 6.5, result;
            result = value1 + value2;
            return result;
        }

        void Display()
        {
            Console.WriteLine(ProcessValueWithDouble());
        }

        static void Main(string[] args)
        {
            OOP.Main main = new OOP.Main();
            main.Display();
        }

        void Looping()
        {
            // Do While
            int value = 1;
            do
            {
                Console.WriteLine(value);
                value++;
            } while (value < 1);

            Console.WriteLine();

            // While Do
            int valueWhile = 1;
            while (valueWhile < 1)
            {
                Console.WriteLine(valueWhile);
                valueWhile++;
            }

            // For
            for (int i = 0; i < arrIntWithValue.Length; i++)
            {
                Console.WriteLine(arrIntWithValue[i]);
            }

            Console.WriteLine();

            // Foreach
            foreach (var item in arrIntWithValue)
            {
                Console.WriteLine(item);
            }
        }

        void Decision()
        {
            // If
            foreach (var item in arrIntWithValue)
            {
                if (item % 2 == 1 && item % 3 == 0)
                {
                    Console.WriteLine("Bilangan ganjil yang berkelipatan 3 yaitu : " + item);
                }
                else if (item % 2 == 1)
                {
                    Console.WriteLine("Bilangan ganjil yang bukan kelipatan 3 yaitu : " + item);
                }
                else
                {
                    Console.WriteLine("Bilangan yang tidak ganjil yaitu : " + item);
                }
            }

            // Switch
            Console.Write("Masukkan nilai bilangan bulat 1 - 3 : ");
            short value = Convert.ToInt16(Console.ReadLine());
            switch (value)
            {
                case 1:
                    Console.WriteLine("nilai 1 telah diinputkan");
                    break;
                case 2:
                    Console.WriteLine("nilai 2 telah diinputkan");
                    break;
                case 3:
                    Console.WriteLine("nilai 3 telah diinputkan");
                    break;
                default:
                    Console.WriteLine("nilai tidak diketahui");
                    break;
            }
        }

        // ini adalah method yang bernama Process untuk melakukan perhitungan aritmatika

        /* 
         * ini adalah method bernama process
         * process membutuhkan nilai parameter a dan b
         * hasil yang akan ditampilkan berupa bilangan bulat
         */
        void Process(int a, int b)
        {
            // menambahkan nilai pada variable a dengan variable b
        }
        #endregion closing
    }

    class Coba2
    {
        public Coba2(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}