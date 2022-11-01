using ElectricityBill;

UnitAmount ua=new UnitAmount();
Console.WriteLine("Enter units for Electricity Bill");
double eUnits = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter you service type, if domestict say 'y' or 'Y', if not say 'n' or 'N': ");
string serviceType =Console.ReadLine();
ua.UnitCal(eUnits, serviceType);


Console.WriteLine("Bill Amount Bill is:{0}", ua.BillAmount.ToString("0.00"));