using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        Journal myJournal = new Journal();
        Boolean continueWriting = true;

        while(continueWriting)
        {
            Console.WriteLine("\n1. Write new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Display Specific Entry");
            Console.WriteLine("4. Remove Specific Entry");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option (1-5): ");
        
            string choice = Console.ReadLine();

            switch(choice)
            {
                case "1":
                    Entry newEnrty = new Entry();
                    newEnrty.WriteEntry();
                    myJournal.AddEntry(newEnrty);
                    break;
                case "2":
                    myJournal.DisplayEntries();
                    break;
                case "3":
                    Console.Write("Enter Entry Index: ");
                    int entryIndex = int.Parse(Console.ReadLine());
                    myJournal.GetEntry(entryIndex).ReadEntry();
                    break;
                case "4":
                    Console.Write("Enter Entry Index: ");
                    int removeIndex = int.Parse(Console.ReadLine());
                    myJournal.RemoveEntry(myJournal.GetEntry(removeIndex));
                    break;
                case "5":
                    continueWriting = false;
                    break;

                default:
                    break;
            }

        }


    }
}