﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("compliment of AAAA");
            Console.WriteLine(DnaStrand.MakeComplement("AAAA"));
            Console.ReadKey();
        }
    }

    public class DnaStrand
    {
        public static string MakeComplement(string dna)
        {
            dna = dna.Replace("T", "0");
            dna = dna.Replace("A", "T");
            dna = dna.Replace("0", "A");
            dna = dna.Replace("C", "0");
            dna = dna.Replace("G", "C");
            dna = dna.Replace("0", "G");

            return dna;
        }
    }
}
