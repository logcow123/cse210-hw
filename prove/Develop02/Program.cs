using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        Entry myEntry1 = new Entry();
        Entry myEntry2 = new Entry();
        Journal myJournal = new Journal();

        myEntry1.WriteEntry();
        myEntry2.WriteEntry();

        myJournal.AddEntry(myEntry1);
        myJournal.AddEntry(myEntry2);

        myJournal.DisplayEntries();
        Console.WriteLine("---------GETTING ENTRY 0---------");
        myJournal.GetEntry(0).ReadEntry();


    }
}