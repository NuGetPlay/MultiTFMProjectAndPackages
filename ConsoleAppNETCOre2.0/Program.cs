using My.Simple.Utilities.Package;
using Simple.Test.Package;
using System;

namespace ConsoleAppNETCOre2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Target Framework from Project Reference: ");
            Console.WriteLine(MyUitilities.GetString());
            Console.Write("Target Framework from Package Reference: ");
            Console.WriteLine(MyUitilitiesFromPackage.GetString());
            Console.ReadLine();
        }
    }
}
