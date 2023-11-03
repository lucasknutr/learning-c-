using FirstApp;

string myName = Console.ReadLine()!;

bool isMyNameLucas (string name)
{
    return name == "Lucas";
}

void printName (string name)
{
    Console.WriteLine(name);
}

if (isMyNameLucas(myName))
{
    Console.WriteLine("Hey, Lucas!");
    printName(myName);
}
else
{
    Console.WriteLine("Not Lucas");
}

