// See https://aka.ms/new-console-template for more information

using static cSharpIn.PersonClass;

cSharpIn.PersonClass p = new cSharpIn.PersonClass
{
    FirstName = "Nazar",
    SecondName = "Kornienko",
    UserName = "blefnk"
};

Console.WriteLine($"Hello, World! My name is {p.FirstName} {p.SecondName}.");
Console.WriteLine($"Welcome to the C# world created by @{p.UserName}");
Console.WriteLine("Please sub and check more of my code: github.com/blefnk");
