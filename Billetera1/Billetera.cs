using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetera1
{
    public class Billetera
    {
        public int BilleteDe10{ get; set; }
        public int BilleteDe20 { get; set; }
        public int BilleteDe50 { get; set; }
        public int BilleteDe100 { get; set; }
        public int BilleteDe200 { get; set; }
        public int BilleteDe500 { get; set; }
        public int BilleteDe1000 { get; set; }


        public decimal Total()
        {
            decimal TotalBillete10 = BilleteDe10 * 10;
            decimal TotalBillete20 = BilleteDe20 * 20;
            decimal TotalBillete50 = BilleteDe50 * 50;
            decimal TotalBillete100 = BilleteDe100 * 100;
            decimal TotalBillete200 = BilleteDe200 * 200;
            decimal TotalBillete500 = BilleteDe500 * 500;
            decimal TotalBillete1000 = BilleteDe1000 * 1000;

            decimal Total = TotalBillete10 + TotalBillete20 + TotalBillete50 + TotalBillete100 + TotalBillete200 + TotalBillete500 + TotalBillete1000;
            return Total;
        }

        public  Billetera Combinar(Billetera miSegundaBilletera)
        {
            Billetera nuevaBilletera = new Billetera();

            int SumaTotal10 = BilleteDe10 + miSegundaBilletera.BilleteDe10;
            int SumaTotal20 = BilleteDe20 + miSegundaBilletera.BilleteDe20;
            int SumaTotal50 = BilleteDe50 + miSegundaBilletera.BilleteDe50;
            int SumaTotal100 = BilleteDe100 + miSegundaBilletera.BilleteDe100;
            int SumaTotal200 = BilleteDe200 + miSegundaBilletera.BilleteDe200;
            int SumaTotal500 = BilleteDe500 + miSegundaBilletera.BilleteDe500;
            int SumaTotal1000 = BilleteDe1000 + miSegundaBilletera.BilleteDe1000;
           
            return nuevaBilletera;
        }

        
    }
}
