using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Base_Console_App_5
{
    internal class GuidEg
    {
        static void Main(string[] args)
        {
            // ToString("N") - To remove the Dashes Automatically
            string guid_org = Guid.NewGuid().ToString("N");

            string guid_str = Regex.Replace(guid_org, "[0-9]", "");

            Console.WriteLine("guid_org : " + guid_org + " \t guid_str : " + guid_str);
            Console.WriteLine("guid_org : " + guid_org.Length + " \t guid_str : " + guid_str.Length);

            Guid newID = Guid.NewGuid();

            string guid_N = newID.ToString("N");
            string guid_default = newID.ToString("D");
            string guid_B = newID.ToString("B");
            string guid_P = newID.ToString("P");
            string guid_X = newID.ToString("X");

            Console.WriteLine("guid original : " + newID);

            Console.WriteLine(" guid_N : " + guid_N );
            Console.WriteLine(" guid_D: " + guid_default );
            Console.WriteLine(" guid_B : " + guid_B );
            Console.WriteLine(" guid_P : " + guid_P );
            Console.WriteLine(" guid_X : " + guid_X );
        }
    }
}
