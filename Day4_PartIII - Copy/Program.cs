using System;

namespace Day4_PartIII
{
    class Program
    {
        static void Main(string[] args)
        {
            Operations org = new Operations("SIA mans uznemums");
            org.AddNew("Kaija", "Putnina", new DateTime(1980));
            org.AddNew("Dzidra", "Zupa", new DateTime (1979));
            org.AddNew("Rudolfs", "Briedis", new DateTime (1983));
            org.Fire("Dzidra", "Zupa");
            org.ChangeData("Rudolfs", "Briedis", new DateTime (1973));
            org.Print();
        }
    }
}
