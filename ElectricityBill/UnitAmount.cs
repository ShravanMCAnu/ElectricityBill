using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityBill
{
    public class UnitAmount
    {
        public double BillAmount { get; set; }
        public void UnitCal(double _units, string _domestic)
        {
            if (_domestic == "y" || _domestic == "Y")
            {
                if (_units > 200)
                {
                    BillAmount = _units * 1.3;
                }
                else if (_units > 400)
                {
                    BillAmount = _units * 2.4;
                }
                else if (_units > 600)
                {
                    BillAmount = _units * 3.6;
                }
                else
                {
                    BillAmount = _units * 0.8;
                }
            }
            else
            {
                if (_units > 200)
                {
                    BillAmount = _units * 2;
                }
                else if (_units > 400)
                {
                    BillAmount = _units * 3.2;
                }
                else if (_units > 600)
                {
                    BillAmount = _units * 5.1;
                }
                else
                {
                    BillAmount = _units * 1.3;
                }
            }
        }
    }
}
