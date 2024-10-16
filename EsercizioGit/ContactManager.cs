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
            ManageUserDecisions();
            continueProgram = ContinueBool();

        } while (continueProgram);
    }


    public void ManageUserDecisions()
    {
        byte decision;
        Console.Write("1 - add contact | 2 - view all contacts | 3 - search a contact | 4 - delete a contact:  ");
        decision = byte.Parse(Console.ReadLine());
        switch (decision)
        {
            case 1:
                AddContact();
                break;
            case 2:
                ViewAllContacts();
                break;
            case 3:
                SearchContact();
                break;
            case 4:
                DeleteContact();
                break;
            default:
                Console.WriteLine($"{decision} is not a command");
                break;
        }
    }

    public void AddContact()
    {
        Console.Write("Insert the name of the new contact: ");
        string name = Console.ReadLine();
        if (!contacts.Contains(new Contact(name)))
        {
            contacts.Add(new Contact(name));
            Console.WriteLine("Added " +  name);    
        }
        else
        {
            Console.WriteLine("The contact is alerady in the list");
        }
    }

    public void ViewAllContacts()
    {
        Console.WriteLine("Contact List:");
        foreach (Contact c in contacts)
        {
            Console.WriteLine($"- {c.Name}");
        }
    }

    public void SearchContact()
    {
        Console.Write("Insert the contact to search: ");
        string ricerca = Console.ReadLine();
        List<Contact> tempContacts = contacts.Where(c => c.Name == ricerca).ToList();
        Console.WriteLine("List of contacts found:");
        foreach (Contact c in tempContacts)
        {
            Console.WriteLine($"- {c.Name}");
        }
    }

    public void DeleteContact()
    {
        Console.Write("Insert the name of the contatc you want to delete: ");
        string deleteName = Console.ReadLine();
        contacts.RemoveAll(c => c.Name == deleteName);
        Console.WriteLine("Deleted "+ deleteName);
    }

    public bool ContinueBool()
    {
        

        Char key;
        do
        {
            Console.WriteLine("Do you want to exit the program? N to continue, Y to exit.");
            key = Console.ReadKey().KeyChar;
            if (key == 'N')
            {
                Console.WriteLine();
                return true;
            }
            else if (key == 'Y')
            {
                Console.WriteLine();
                Console.WriteLine("Program End");
                return false;
            }
            else {
                Console.WriteLine();
                Console.WriteLine("Not the right key"); 
            }
        }
        while (key != 'N' || key != 'Y');
        

        return false;
    }
}
