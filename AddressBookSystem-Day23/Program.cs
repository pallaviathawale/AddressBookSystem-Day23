namespace AddressBookSystem_Day23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("...Welcome to Address Book...");
            AddressBooks Book = new AddressBooks();
            Book.CreateContact();
            Console.ReadLine();


        }
    }
    
}