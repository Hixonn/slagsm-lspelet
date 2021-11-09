using System;

Random random = new Random();
int tantHP;
int yourHP;
int randomInt;
string input;

Console.WriteLine("Börja spelet? ja / nej");
input = Console.ReadLine();

if(input == "ja"){
    Console.WriteLine("Okej. Du börjar slåss mot en tant.");
} else {
    Console.WriteLine("Öhh, okej? Vi börjar spelet ändå. Du börjar slåss mot en tant.");
}
