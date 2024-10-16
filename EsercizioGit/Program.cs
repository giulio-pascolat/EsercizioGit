using EsercizioGit;
using System.Net.Http.Headers;

List<Contact> contacts = new List<Contact>()
{
    new Contact("Mario"),
    new Contact("Filippo"),
    new Contact("Gianni"),
    new Contact("Marco"),
    new Contact("Nicola"),
};

bool continueProgram = false;
do
{

    Console.Write("Inserisci il nome del contatto: ");
    string name = Console.ReadLine();   
    contacts.Add(new Contact(name));


    Console.WriteLine("Vuoi uscire dal programma? invio per continuare, esc per uscire");

    ConsoleKeyInfo key = Console.ReadKey();
    if(key.Key == ConsoleKey.Enter) 
    { 
        continueProgram = true;
    }
    else if(key.Key == ConsoleKey.Escape) 
    {
        Console.WriteLine("Fine Programma");
    }

} while (continueProgram);
