
char grade;
Console.WriteLine("Enter your assessment:");
string input = Console.ReadLine().ToUpper(); //ToUpper, так как использвуем заглавные букв3
grade = input[0];

switch (grade) 
{
    case 'A': 
        Console.WriteLine("Suurepärane!");
        break;
    case 'B':
        Console.WriteLine("Väga hea!");
        break;
    case 'C':
        Console.WriteLine("Hea!");
        break;
    case 'D':
        Console.WriteLine("Rahuldav");
        break;
    case 'F':
        Console.WriteLine("Puudulik!");
        break;
    default:
        Console.WriteLine("Vale väärtus");
        break;
}
