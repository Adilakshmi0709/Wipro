// using System;

// namespace oops.poly
// {
//     class InfoPrinter
//     {
//         public int Pages;
//         InfoPrinter()
//         {
//             Console.WriteLine("Constructor Called !");
//         }
//         InfoPrinter(int Pagess)
//         {
//             this.Pages = Pagess;
//             this.Pages = this.Pages + 1;
//             Console.WriteLine("Total Pages Printed : " + this.Pages);
//         }
//         public void Print(string name, int empId)
//         {
//             Console.WriteLine("Name : " + name + ", EmpId : " + empId);
//         }
//         public void Print(int empId, string name)
//         {
//             Console.WriteLine("Name : " + name + ", EmpId : " + empId);
//         }
//         static void Main()
//         {
//             InfoPrinter obj = new InfoPrinter();
//             obj.Print("Ammu", 1001);
//             obj.Print(1002, "Cherry");
//             InfoPrinter obj1 = new InfoPrinter(23);
//             InfoPrinter obj2 = new InfoPrinter(12);
//         }
//     }
// }