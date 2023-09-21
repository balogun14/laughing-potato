// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Console.WriteLine("Variables" );


// string greeting = "Hello, World";
// Console.WriteLine(greeting);
// Console.WriteLine("max value: " + int.MaxValue + " min value: " + int.MinValue);
// Console.WriteLine("max value: " + long.MaxValue + " min value: " + long.MinValue);

// implicit casting
// char c = 'A';
// int newC = c;
// System.Console.WriteLine(newC);

// double score = 45.56;
// int newScore = (int)score;
// System.Console.WriteLine(newScore);

// string h = "89.99";
// decimal h1 = Convert.ToDecimal(h);
// System.Console.WriteLine(h1);

/*
First Name
Last Name
Age
Location
Fav color
Hobby
*/
// System.Console.Write("Enter Your First Name: ");
// string? firstName = Console.ReadLine();
// // System.Console.WriteLine(firstname);

// System.Console.Write("Enter Your Last Name: ");
// string lastName = Console.ReadLine()!;

// System.Console.Write("What\'s  Your age? ");
// string input = Console.ReadLine()!;
// int age = Convert.ToInt32(input);

// System.Console.Write("What\'s Your Location? ");
// string location = Console.ReadLine()!;

// System.Console.Write("What\'s Your Favorite Color? ");
// string favColor = Console.ReadLine()!;

// System.Console.Write("What\'s Your Hobby? ");
// string hobby = Console.ReadLine()!;

// string composition = "My Name is " + firstName + " " + lastName + ".  I am " + age + " years old. " + "I live in " + location + " My Favorite Colour is " + favColor + " I love " + hobby;
// string composition1 = $"My Name is {firstName} ';{lastName} I am {age} years old. I live in {location} My Favorite Colour is {favColor}  I love {hobby}";
// System.Console.WriteLine(Environment.NewLine);
// System.Console.WriteLine(composition);
// System.Console.WriteLine(Environment.NewLine);
// System.Console.WriteLine(composition1);
// int compLenght = composition.Length;
// System.Console.WriteLine(compLenght);
 
 
//  int e=100;
// System.Console.WriteLine(e++);
// System.Console.WriteLine(e);
// System.Console.WriteLine(--e);
// System.Console.WriteLine(e);
// System.Console.WriteLine(e--);
// System.Console.WriteLine(e);

// string name = "Awwal";
// System.Console.WriteLine(name);
// System.Console.WriteLine("{0}",name);


DateTime date = new DateTime(2012,02,27,17,30,22);

System.Console.WriteLine("{0:dd/MM/yyyy HH:mm:ss}",date);
