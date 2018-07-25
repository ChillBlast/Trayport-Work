using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;


namespace CodeWars2
{
    public class Kata5
    {
        public static string GetMiddle(string s)
        {
            string answer = "";
            if (s.Length % 2 == 1)
            {
                answer = "" + s[(s.Length-1)/2];
            }
            else
            {
                answer = "" + s[(s.Length/2)-1] + s[s.Length / 2];
            }

            return answer;
        }
    }
}
