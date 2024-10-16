namespace EsercizioGit;

public class ContactManager
{
    private List<Contact> contacts;

    public ContactManager(List<Contact> contacts)
    {
        this.contacts = contacts;
    }
    

    public void StartProgram()
    {
        bool continueProgram = false;
        do
        {
            Console.Write("Inserisci il nome del contatto: ");
            string name = Console.ReadLine();
            contacts.Add(new Contact(name));

            Console.WriteLine("Lista contatti:");
            foreach(Contact c in contacts)
            {
                Console.WriteLine($"- {c.Name}");
            }

            Console.Write("Inserisci il contatto da cercare: ");
            string ricerca = Console.ReadLine();
            List<Contact> tempContacts = contacts.Where(c => c.Name == ricerca).ToList();
            Console.WriteLine("List of contacts found:");
            foreach (Contact c in tempContacts)
            {
                Console.WriteLine($"- {c.Name}");
            }


            Console.Write("Insert the name of the contatc you want to delete: ");
            string deleteName = Console.ReadLine();
            contacts.RemoveAll(c => c.Name == deleteName);


            Console.WriteLine("Vuoi uscire dal programma? invio per continuare, esc per uscire");

            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                continueProgram = true;
            }
            else if (key.Key == ConsoleKey.Escape)
            {
                Console.WriteLine("Fine Programma");
            }

        } while (continueProgram);
    }

    public void InsertContact()
    {
        Console.Write("Inserisci il nome del contatto: ");
        string name = Console.ReadLine();
        contacts.Add(new Contact(name));
    }
}
