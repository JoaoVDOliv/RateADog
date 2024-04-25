using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

Dictionary<string, List<int>> dogList = new Dictionary<string, List<int>>();

menu();

void menu()
{
    int menuIterator = 0;

    Console.WriteLine("-----------------------------------------------------------------");
    Console.WriteLine("Welcome to Rating my girlfirend's Dogs App");
    Console.WriteLine("This app will allow you to rate a dog from my girlfriend");
    Console.WriteLine("She has 5 dogs");
    Console.WriteLine("-----------------------------------------------------------------");

    populateList();

    do
    {
        Console.WriteLine("Please, select one option to star:");
        Console.WriteLine("1. List of Dogs");
        Console.WriteLine("2. Rate a Dog");
        Console.WriteLine("3. Show Dogs and Notes");
        Console.WriteLine("0. Exit");

        menuIterator = Convert.ToInt32(Console.ReadLine()); 

        switch (menuIterator)
        {
            case 0:
                Console.WriteLine("Bye");
                break;
            case 1:                
                showDogList();
                break;
            case 2:
                rateDog();
                break;
            case 3:
                showDogRate();
                break;
        }

    } while (menuIterator != 0);
}

void showDogList()
{
    Console.WriteLine("We show all dogs!!!");

    foreach (string dog in dogList.Keys)
    {
        Console.WriteLine(dog);
    }
}

void rateDog()
{
    Console.Clear();

    int note = 0;
    string dogName;

    Console.WriteLine("You can rate a dog here");

    showDogList();

    Console.WriteLine("Please, Type the name of the dog you want to rate: ");

    dogName = Console.ReadLine();

    if (dogList.ContainsKey(dogName)) 
    {
        Console.WriteLine("Please, type a note from 0 - 10");

        do
        {
            note = Convert.ToInt32(Console.ReadLine());

            if (note > 10 || note < 0)
                Console.WriteLine("You must type values beetwen 0 and 10");

        } while (note > 10 || note < 0);

        dogList[dogName].Add(note);

        Console.WriteLine($"Note {note} to dog {dogName} was registered");
    }
    else 
    {
        Console.WriteLine("We couldn't find any Dog, please try again");
    }
}

void showDogRate()
{
    foreach (KeyValuePair<string, List<int>> dog in dogList) 
    {
        Console.Write($"Dog: {dog.Key} - ");
        
        foreach (int value in dog.Value) 
        {            
            Console.Write($"{value} - ");
        }

        Console.WriteLine("");
    }
}

void populateList()
{
    dogList.Add("Akira"   , new List<int>());
    dogList.Add("Leao"    , new List<int>());
    dogList.Add("Neguinha", new List<int>());
    dogList.Add("Nina"    , new List<int>());
    dogList.Add("Thor"    , new List<int>());
}



