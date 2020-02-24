using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Novicap
{
    class Program
    {
        static void Main(string[] args)
        {
            var invoice = new Invoice();
            Console.WriteLine("Your Total Amount is : " + invoice.GetInvoice(args.ToList(), @"..\Novicap\ProductConfig.json"));
        }
    }
}
