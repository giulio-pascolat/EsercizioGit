using EsercizioGit;

List<Contact> contacts = new List<Contact>()
{
    new Contact("Mario"),
    new Contact("Filippo"),
    new Contact("Gianni"),
    new Contact("Marco"),
    new Contact("Nicola"),
};

ContactManager contactManager = new ContactManager(contacts);
contactManager.StartProgram();
