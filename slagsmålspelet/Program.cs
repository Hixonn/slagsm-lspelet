using System;

Random random = new Random();
int tantHP = 100;
int yourHP = 100;
int randomInt;
string input;

Console.WriteLine("Börja spelet? ja / nej");
input = Console.ReadLine();

if(input == "ja"){
    Console.WriteLine("Okej. Du börjar slåss mot en tant.");
    Console.ReadKey();
} else {
    Console.WriteLine("Öhh, okej? Vi börjar spelet ändå. Du börjar slåss mot en tant.");
    Console.ReadKey();
}


while (tantHP >= 0 && yourHP >= 0){
    randomInt = random.Next(1,10);
    if (randomInt >= 6) {

        Console.WriteLine("Tanten ger dig en örfil!");

        randomInt = random.Next(1,10);
        yourHP -= randomInt;

        Console.WriteLine($"Du har {yourHP}HP || Tant {tantHP}HP");
        Console.WriteLine();
        Console.WriteLine("Tryck på nån knapp för att fortsätta...");
        Console.ReadKey();
        Console.Clear();

    } else if (randomInt < 6) {

        Console.WriteLine("Du får in ett slag på tanten.");

        randomInt = random.Next(1,10);
        tantHP -= randomInt;
    
        Console.WriteLine($"Du har {yourHP}HP || Tant {tantHP}HP");
        Console.WriteLine();
        Console.WriteLine("Tryck på nån knapp för att fortsätta...");
        Console.ReadKey();
        Console.Clear();
    }
} 

if (tantHP <= 0)
{
    Console.WriteLine("Bra jobbat du har mördat en försvarslös tant!");
    Console.WriteLine("Spelet är nu slut.");
    Console.ReadKey();
}

if (yourHP <= 0)
{
    Console.WriteLine("Du dog av en tant.");
    Console.WriteLine("Spelet är nu slut.");
    Console.ReadKey();
}

