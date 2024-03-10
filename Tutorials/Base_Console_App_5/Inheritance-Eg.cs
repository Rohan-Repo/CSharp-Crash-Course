using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Console_App_5
{
    internal class Inheritance_Eg
    {

        class Headphone
        {
            protected Guid hpId {  get; init; }
            protected string hpBrand { get; init; } = string.Empty;
            protected string hpType { get; init; } = string.Empty;

            public Headphone(Guid hpId, string hpBrand, string hpType)
            {
                this.hpId = hpId;
                this.hpBrand = hpBrand;
                this.hpType = hpType;
            }

        }

        class HeadphoneType : Headphone
        {
            private bool hpHasANC { get; init; }

            public HeadphoneType(Guid hpId, string hpBrand, string hpType, bool hpHasANC) : base(hpId, hpBrand, hpType)
            {
                this.hpHasANC = hpHasANC;
            }

            public void printHPDetails()
            {
                Console.WriteLine("\n Headphone Details : ");
                Console.WriteLine("\t hpId : " + this.hpId);
                Console.WriteLine("\t hpBrand : " + this.hpBrand );
                Console.WriteLine("\t hpType : " + this.hpType);
                Console.WriteLine("\t hpHasANC : " + this.hpHasANC);
            }
        }

        //static void Main(string[] args)
        //{
        //    HeadphoneType hp_1 = new HeadphoneType(Guid.NewGuid(), "Bose", "Wireless", true );
        //    hp_1.printHPDetails();

        //    HeadphoneType hp_2 = new HeadphoneType(Guid.NewGuid(), "Sony", "Wired", false );
        //    hp_2.printHPDetails();
        //}
    }
}
