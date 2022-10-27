


Dictionary<string, double> menu = new Dictionary<string, double>()
{
    {"eggs",4.99 },
    {"milk", 2.99},
    {"butter",3.99},
    {"bread",2.50 },
    {"ketchup",3.25 },
    {"soup",4.25 },
    {"cookies",5.25 },
    {"cheese", 6.25 }
};

bool addMore = true;

List<double> currentPriceList = new List<double>();


Console.WriteLine("Welcome to GC Market! Here is what we have today");
DisplayMenuList(menu);

Console.WriteLine();


do
{
    BuildList();
    Console.WriteLine("Would you like to grab another item? (y/n)");
    string add = Console.ReadLine();
    addMore = add.ToLower() == "y";


} while (addMore==true);

Console.WriteLine("Are you ready to check out? (y/n)");
string checkOut = Console.ReadLine().ToLower();

if (checkOut == "y")
{
    string shoppingList = shoppingList.ToLower();  // This is where I hit the struggle bus
    Console.WriteLine("Here is your receipt and total: ");

    foreach (string item in shoppingList)
    {
        Console.WriteLine(item);
    }

}


string BuildList(string shoppingList)
{
    List<string> shoppingList = new List<string>(); // this is where the struggle bus hit me back
    Console.WriteLine("");
    Console.WriteLine("What are you buying today?");
    bool onMenu = menu.ContainsKey(Console.ReadLine().ToLower());


    if (onMenu==true)
    {
        Console.WriteLine("Great! We have that in stock");
        string addItem = Console.ReadLine();
        shoppingList.Add(addItem);

    }
    else
    {
        Console.WriteLine("Sorry, we don't have that in today");
    }

    //return shoppingList;
}




void DisplayMenuList(Dictionary<string, double> menu)
{
    foreach (KeyValuePair<string, double> item in menu)
    {
        Console.WriteLine(item.Key + "- $" + item.Value);
    }
}

Console.ReadKey();