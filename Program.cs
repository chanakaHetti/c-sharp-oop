Console.WriteLine("Hello, World!");

// String and String methods
Console.WriteLine("----------- String and String methods -----------");

string firstName = "       Chanaka     ";
firstName = firstName.Trim();

string lastName = "         HA      ";

string fullName = $"My name is: {firstName} {lastName.Trim()}";

Console.WriteLine(fullName);
Console.WriteLine(fullName.Replace("HA", "Dileep"));
Console.WriteLine(fullName);

Console.WriteLine("Assign the value----------------");
fullName = fullName.Replace("HA", "Dileep");
Console.WriteLine(fullName);

Console.WriteLine(fullName.Contains("Chanaka"));
Console.WriteLine(fullName.Contains("chanaka"));

Console.WriteLine(fullName.ToUpper());

Console.WriteLine(fullName.Length);

// Numbers and number methods
Console.WriteLine("----------- Numbers and number methods -----------");

int a = 18;
int b = 6;
int c = a + b;

Console.WriteLine(c);

Console.WriteLine("Long number (More then 2.1 billion) -------------");

int d = 2100000000;
int e = 2100000000;
long f = d + e; // Long isn't work here too. Result os too long

Console.WriteLine(f);

long g = (long)d + (long)e;

Console.WriteLine(g);

// long h = checked(d + e);

// Console.WriteLine(h); // This shows some Unhandled exception.

double aa = 4.254;
double bb = 10.89;

double cc = aa + bb;

Console.WriteLine(cc);

// double is natural type
// float ee = 12.458F

float ee = 12.45F;

Console.WriteLine(ee);

// If statements

int aaa = 5;
int bbb = 6;
int ccc = aaa + bbb;

if (ccc < 10) {
    Console.WriteLine("If state");
} else if (ccc == 10) {
    Console.WriteLine("If else state");
} else {
    Console.WriteLine("Else state");
}

Console.WriteLine("outside If state");

// While loops
int counterOne = 0;
int counterTwo = 0;

while (counterOne <= 5) {
    counterOne++;
    Console.WriteLine(counterOne);
}

Console.WriteLine("Break-----------");

while (counterTwo <= 5) {
    Console.WriteLine(counterTwo);
    counterTwo++;
}

Console.WriteLine("Do while loop -----------");

// Do while loop
int counterThree = 0;
do {
    Console.WriteLine(counterThree);
    counterThree++;
}
while (counterThree <= 5);

// For loop

Console.WriteLine("For loop ------------");

for (int i = 0; i <= 5; i++) {
    Console.WriteLine(i);
}

// List and collections
Console.WriteLine("List ------------");

var names = new List<string> { "<name>", "Chanaka", "Dileep" };

names.Add("Buddhika");
names.Add("HA");

Console.WriteLine(names);

foreach (var name in names) {
    Console.WriteLine($"Hello {name.ToUpper()}!");
};

for (int i = 0; i < names.Count; i++) {
    Console.WriteLine($"Hello {names[i].ToUpper()}!");
}

Console.WriteLine(names[0]);
Console.WriteLine(names[2]);

Console.WriteLine(names[names.Count - 1]);
Console.WriteLine(names[^1]);

foreach (var name in names[2..4]) {
    Console.WriteLine($"Hello {name.ToUpper()}!");
};

Console.WriteLine("String Array-------------");

var namesArray = new string[] { "<name>", "Chanaka", "Dileep" };

// Array is fixed so can't run .Add 
// To add
namesArray = [.. namesArray, "Buddhika"];

Console.WriteLine(namesArray);

foreach (var name in namesArray) {
    Console.WriteLine($"Hello {name}");
}

Console.WriteLine("List Sort----------------------");

var listNames = new List<string> { "Chanaka", "Dileep", "Buddhika" };

listNames.Sort();

foreach (var name in listNames) {
    Console.WriteLine($"Hello {name.ToUpper()}!");
}

var listNumber = new List<int> { 12, 18, 47, 86, 103, 18, 29, 98, 65, 54 };

Console.WriteLine($"Number 29's index is {listNumber.IndexOf(29)}");
listNumber.Sort();
Console.WriteLine($"Number 29's index is {listNumber.IndexOf(29)}");

foreach (var number in listNumber) {
    Console.WriteLine($"{number}");
}

