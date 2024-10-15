internal class Program
{
    // this is Main
    private static void Main(string[] args)
    {
        // Це я зробив з використанням циклу. Нижче закоментований код без використанння циклу
        const decimal PriceOfSmartfone = 305.99m, PriceOfLaptop = 570.95m, PriceOfKeyboard = 5.50m;

        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine($"Order No {i}");

            Console.Write("Name of Client: ");
            string? NameOfClient = Console.ReadLine();

            Console.Write("What you are want to by (smartphone, laptop, keyboard): ");
            string? Client_Product = Console.ReadLine();

            Console.Write("Give your adress: ");

            string? AdressOfClient = Console.ReadLine();

            decimal FinalPrice;

            if (Client_Product == "smartphone")
            {
                FinalPrice = PriceOfSmartfone;
            }
            else if (Client_Product == "laptop")
            {
                FinalPrice = PriceOfLaptop;
            }
            else if (Client_Product == "keyboard")
            {
                FinalPrice = PriceOfKeyboard;
            }
            else
            {
                Console.WriteLine("Product not recognized");
                i--;
                continue;
            } 

            Console.Clear();

            Console.WriteLine($"Order No {i}\nClient: {NameOfClient}.\nProduct: {Client_Product}, {FinalPrice} EUR.\nAdress: {AdressOfClient}");
        }
    }
}
// feature
// Тут я пробував зробити без використання циклу, все працює але я розумію що продовжувати немає сенсу так як код буде дуже довгий


//{
//    Console.WriteLine("First Order");
//    Console.Write("Name of Client: ");
//    string? NameOfClient = Console.ReadLine();
//    Console.Write("What you are want to by (smartphone, laptop, keyboard): ");
//    string? Client_Product = Console.ReadLine();
//    Console.Write("Give your adress: ");
//    string? AdressOfClient = Console.ReadLine();

//    const decimal PriceOfSmartfone = 305.99m, PriceOfLaptop = 570.95m, PriceOfKeyboard = 5.50m;

//    decimal FinalPrice = 0;

//    if (Client_Product == "smartphone")
//    {
//        FinalPrice = PriceOfSmartfone;
//    }
//    else if(Client_Product == "laptop")
//    { 
//        FinalPrice= PriceOfLaptop;

//    }else if(Client_Product == "keyboard")
//    {
//        FinalPrice = PriceOfKeyboard;
//    }
//    else
//    {
//        Console.WriteLine("Product not recognized.");
//        return; 
//    }
//    Console.Clear();


//    Console.WriteLine($"Order No 1\nClient: {NameOfClient}.\nProduct: {Client_Product}, {FinalPrice} EUR.\nAdress: {AdressOfClient}");
//}

