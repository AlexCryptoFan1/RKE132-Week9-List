



string folderPath = @"C:\Users\Admin\Documents\progging\data";
string fileName = "shoppingList.txt";
string filePath = Path.Combine(folderPath, fileName);
List<string> myShoppingList = new List<string>();
if(File.Exists(filePath))
{
    myShoppingList = getItemsFromUser();
    File.WriteAllLines(filePath, myShoppingList);
}
else
{
    File.Create(filePath).Close();
    Console.WriteLine($"File {fileName} created");
    myShoppingList = getItemsFromUser();
    File.WriteAllLines(filePath, myShoppingList);
}



static List<string> getItemsFromUser ()
{
    List<string> userList = new List<string>();

    while (true)
    {
        Console.WriteLine("Add and item (add)/ Exit (exit)");
        string userChoice = Console.ReadLine();

        if (userChoice == "add")
        {
            Console.WriteLine("item");
            string userItem = Console.ReadLine();
            userList.Add(userItem);
        }
        else
        {
            Console.WriteLine("bye");
            break;
        }

    }
    return userList;
}

static void ShowItemsFromList(List<string> someList)
{
    Console.Clear();

    int listLength = someList.Count;
    Console.WriteLine($"U have added {listLength} items");
    int i = 1;

    foreach (string item in someList)
    {
        Console.WriteLine(item);
        Console.WriteLine(i);
        i++;
    }
}
