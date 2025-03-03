using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using odev1_ınheritance.Classes;

namespace odev1_ınheritance
{
    public class Program
    {
        static void Main(string[] args)
        {
            BMW b1 = new BMW();
            b1.vites = "düz";
            b1.vitesname();
        

            Audi audi = new Audi();
            audi.vites = "otomatik";
            audi.vitesname();   

            Mercedes mercedes = new Mercedes();
            mercedes.vites = "düz";
            mercedes.vitesname();

            Porsche porsche = new Porsche();
            porsche.vites = "otomatik";
            porsche.vitesname();    

            Togg togg = new Togg();
            togg.vites = "otomatik";
            togg.vitesname();   

            Toyota toyota = new Toyota();
            toyota.vites = "düz";
            toyota.vitesname();
        }
    }
}
