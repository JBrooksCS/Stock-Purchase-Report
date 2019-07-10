using System;
using System.Collections.Generic;

namespace Stock_Purchase_Report
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("MSFT", "Microsoft");
            stocks.Add("APL", "Apple");
            stocks.Add("SGHD", "StrangeHandle");

            var purchases = new Dictionary<string, List<string>>();
            purchases.Add("APL", new List<string>{"1214.99"});
            purchases.Add("APL", new List<string>{"1220.99"});
            purchases.Add("APL", new List<string>{"1299.99"});
            purchases.Add("CAT", new List<string>{"1314.99"});
            purchases.Add("CAT", new List<string>{"12124.99"});
            purchases.Add("CAT", new List<string>{"121224.99"});
            purchases.Add("SGHD", new List<string>{"12414.99"});
            purchases.Add("SGHD", new List<string>{"12314.99"});
            
        }
    }
}
