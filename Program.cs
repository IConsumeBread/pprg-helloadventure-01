/* 
// Wizytówka
Console.WriteLine("Wpisz swoje imię");
string name = Console.ReadLine();
Console.WriteLine("Podaj swój wiek");
int age = int.Parse(Console.ReadLine());
Console.WriteLine("Podaj swoją ulubioną grę");
string game = Console.ReadLine();

Console.WriteLine("WIZYTÓWKA");
Console.WriteLine($"Imię: {name}");
Console.WriteLine($"Wiek: {age}");
Console.WriteLine($"Gra: {game}"); */

/* 

// Powitanie użytkownika + rok później
Console.WriteLine("What's your name?");
string name = Console.ReadLine();

Console.WriteLine("What's your favorite color?");
string color = Console.ReadLine();

Console.WriteLine("How old are you?");
int age = int.Parse(Console.ReadLine());

Console.WriteLine($"Hello, {name}! {color} is a great color. Next year you will be {age + 1}!"); */

// Kalkulator podróży
/* 
Console.WriteLine("What's your km goal?");
int kmgoal = int.Parse(Console.ReadLine());

Console.WriteLine("How many km do you walk per day?");
int kmdaily = int.Parse(Console.ReadLine());

Console.WriteLine($"You will reach your goal in {kmgoal / kmdaily} days.");
*/

string gametitle = "Epic Indieslop";
string[] classes = {"Warrior", "Mage", "Archer"};
string[] titles = {"No Title", "The Strongest", "The Wise"};

Random rnd = new Random();
int classChoice = rnd.Next(0, classes.Length);
int titleChoice = rnd.Next(0, titles.Length);

Console.WriteLine($"Welcome to {gametitle}! Please enter your name:");
string name = Console.ReadLine();

int base_HP = 100;
int startlvl = 12;
int startGold = 0;

Console.WriteLine($"* * * * {gametitle} * * * *");
Console.WriteLine("\tCharacter Details");
Console.WriteLine($"\tHero Name: {name}\n\tTitle: {titles[titleChoice]}\n\tClass: {classes[classChoice]}\n\tHP: {base_HP}\n\tLevel: {startlvl}\n\tGold: {startGold}");
Console.WriteLine("* * * * * * * * * * * * * * *");