// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//List<int> myInt = new List<int>();

//myInt.Add(1);
//myInt.Add(2);
//myInt.Add(3);

//Console.WriteLine(myInt[0
//


Dictionary<string, string> ContactNumbers = new Dictionary<string, string>();

int Choice;
string ContactID;
string ContactValue;

bool running = true;

while (running)
{
    Console.WriteLine();
    Console.WriteLine("This is contact numbers what do you want to do? ");
    Console.WriteLine("1. Add a contact number");
    Console.WriteLine("2. See the contact numbers");
    Console.WriteLine("3. Remove a contact number");
    Console.WriteLine("4. Update a contact number");
    Console.WriteLine("5. Exit");
    Choice = Convert.ToInt32(Console.ReadLine());

    if (Choice == 1)
    {

        Console.Write("Enter contact ID (name): ");
        ContactID = Console.ReadLine().ToUpper();

        if (string.IsNullOrWhiteSpace(ContactID))
        {
            Console.WriteLine("Contact ID cannot be empty. Please try again.");

        }

        else if (ContactNumbers.ContainsKey(ContactID))
        {
            Console.WriteLine("Sorry that contact ID already exist");
        }

        else
        {
            Console.Write("Enter contact number: ");
            ContactValue = Console.ReadLine();


            if (ContactValue.Length == 11 && ContactValue.All(char.IsDigit) && !string.IsNullOrWhiteSpace(ContactValue) && !ContactNumbers.ContainsValue(ContactValue)) 
            {
                ContactNumbers.Add(ContactID, ContactValue);
                Console.WriteLine("The number added successfully");
            }

            else
            {
                Console.WriteLine("Invalid number, it must be 11 digits or unique.");
            }
        }

    }


    else if (Choice == 2)
    {
        Console.Write("Enter contact ID: ");
        ContactID = Console.ReadLine();
        ContactID = ContactID.ToUpper();
        

        if (ContactNumbers.ContainsKey(ContactID))
        {
            Console.WriteLine($"Contact ID: {ContactID} | Contact Numbers: {ContactNumbers[ContactID]}");
        }

        else
        {
            Console.WriteLine("No contact numbers found.");
        }
    }

   

    else if (Choice == 3)
    {
        Console.Write("Enter the ID that you want to remove: ");
        ContactID = Console.ReadLine().ToUpper();
        
        if (ContactNumbers.ContainsKey(ContactID))
        {
            ContactNumbers.Remove(ContactID);
            Console.Write($"The number of {ContactID} successfully removed");
        }

        else
        {
            Console.WriteLine("No contact found with that ID");
        }
        
     }

    else if (Choice == 4)
    {
        Console.Write("Enter the the contact id that you want to update: ");
        ContactID = Console.ReadLine().ToUpper();
        Console.Write("Enter new number: ");
        ContactValue = Console.ReadLine();
        ContactNumbers[ContactID] = ContactValue;
        if (ContactNumbers.ContainsKey(ContactID))
        {
            Console.WriteLine("The contact number successfully updated");
        }

        else
        {
            Console.WriteLine("Contact doesn't exist");
        }
    }

    else if (Choice == 5)
    {

        running = false;


    }

    else
    {
        Console.WriteLine("Invalid choice");


    }

    }