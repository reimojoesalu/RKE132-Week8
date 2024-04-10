string folderPath = @"C:\Users\reimo\source\repos\Week8EpicGame";
string heroFile = "heros.txt";
String villianFile = "villians.txt";

string[] heros = File.ReadAllLines(Path.Combine(folderPath, heroFile));
string[] Villians = File.ReadAllLines(Path.Combine(folderPath, villianFile));



string[] heroes = { "Harry Potter", "LUke Skywalker", "Lara Croft", "Scooby-Doo" };
string[] villains = { "Voldemort", "Darth Valder", "Dracula", "Joker", "Sauron" };
string[] weapon = { "magic wand", "plastic fork", "Banana", "wooden sword", "lego brick" };




string hero = GetRandomValueFromArry(heroes);
string heroWeapon = GetRandomValueFromArry(weapon);
int heroHP = GetCharacterHP(hero);
int heroStrikesStrength = heroHP;
Console.WriteLine($"Today {hero} ({heroHP} HP) with {heroWeapon} save the day!");



string villain = GetRandomValueFromArry(villains);
string villainWeapon = GetRandomValueFromArry(weapon);
int villianHP = GetCharacterHP(villain);
int villainsStrikeStrength = villianHP;
Console.WriteLine($"Today {villain} ({villianHP} HP) with {villainWeapon} tries to take over the world!");

while(heroHP >0 && villianHP > 0)
{
    heroHP = heroHP - Hit(villain, villianHP);
    villianHP = villianHP - Hit(hero, heroStrikesStrength);
}
Console.WriteLine($"Hero {hero} HP {heroHP}"); 
Console.WriteLine($"Villian {villain} HP: {villianHP}");
if(heroHP > 0)
{
    Console.WriteLine($"{hero} saves the day!");
}
else if (villianHP > 0)
{
    Console.WriteLine($"Dark side wins!");
}
else
{
    Console.WriteLine("Draw!");
}

static string GetRandomValueFromArry(string[] someArry)
{
  Random rnd = new Random();
  int randomIntex = rnd.Next(0, someArry.Length);
  string randomStringFromArray = someArry[randomIntex];
   return randomStringFromArray;

}

static int GetCharacterHP(string characterName)
{
    if (characterName.Length < 10)
        {
        return 10;
    }
    else
    {
        return characterName.Length;
    }
}
static int Hit(string characterName, int characterHP)
{
    Random rnd = new Random();
    int strike = rnd.Next(0, characterHP);

    if (strike == 0)
    {
        Console.WriteLine($"{characterName} missed the target!");
    }
    else if (strike == characterHP - 1)
    {
        Console.WriteLine($"{characterHP} made a critical hit!");
    }
    else
    {
        Console.WriteLine($"{characterName} hit {strike}!");
    }

    return strike;

}
