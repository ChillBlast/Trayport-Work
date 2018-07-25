using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars2
{
    public class Kata4
    {
        public static string FakeBin(string x)
        {
            StringBuilder sb = new StringBuilder();
            string result = "";
            for (int i = 0; i < x.Length; i++)
            {
                char ch;
          
                if (x[i] < '5')
                {
                    ch = '0';
                }
                else
                {
                    ch = '1';
                }

                result += ch;
                //sb.Append(ch);
            }

            return result;//sb.ToString();
        }
    }
}
