using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars2
{
    //public class Person
    //{
    //    public string Name;
    // public string Address;

    //}

    public class Kata7
    {
        public static int DuplicateCount(string str)
        {
            str = str.ToLower();
            var charDict = new Dictionary<char,int>();

            foreach (var c in str)
            {
                if (!charDict.ContainsKey(c)) charDict[c] = 0;
                charDict[c] += 1;
            }

            //var persons = new Person[10];
            //persons[0].Name

            return charDict.Count(i => i.Value > 1);
            }
    }
}
