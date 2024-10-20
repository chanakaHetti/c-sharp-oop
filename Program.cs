Console.WriteLine("Hello, World!");

// String methods

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
