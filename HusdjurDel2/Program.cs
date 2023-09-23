
// Sortera nu listan efter ålder och spara detta i en ny fil.
// Ni ska använda File.WriteAllLines för att lösa detta.



string[] list = File.ReadAllLines("../../../../Husdjuren.csv");

Dictionary<string, int> pets = new Dictionary<string, int>();

foreach (string word in list)
{
    
    string[] newList = word.Split(";"); // separerar orden som har ; emellan
    if (int.TryParse(newList[1], out int age)) // konverterar item på plats 2 till integer
    {
        pets.Add(newList[0], age); // lägger in listan i pets dictionary, assignar name och key value
    }
    Console.WriteLine(pets);
}



/*
{'Leo','2009'},
{'Sheldon','2018'}
Batman,2016
Kola,2020
Sushi,2021


sing System.Net.Security;

string[] nameAndYear = File.ReadAllLines("../../../csv.txt");

List<int> birthYear = new List<int>();

List<string> nameOfPet = new List<string>();

int selected;

foreach (string item in nameAndYear)
{
    string[] items = item.Split(',');
    nameOfPet.Add(items[0]);
    if (int.TryParse(items[1], out selected))
    {
        birthYear.Add(selected);
    }
}


Dictionary<string, int> nameToBirthYear = new Dictionary<string, int>();


for (int i = 0; i < 4; i++)
{
    nameToBirthYear.Add(nameOfPet[i], birthYear[i]);
}

Console.WriteLine("Pick pet");
string input = Console.ReadLine();

switch (nameToBirthYear.ContainsKey(input))
{

    case true:
        Console.WriteLine("Age " + nameToBirthYear[input]);
        break;
    default:
        Console.WriteLine("He dead");
        break;
}
List<string> o = new List<string>();
foreach (KeyValuePair<string, int> item in nameToBirthYear.OrderBy(key => key.Value))
{
    o.Add(item.Key + "," + item.Value);
}

File.WriteAllLines("../../../names.txt", o);

*/