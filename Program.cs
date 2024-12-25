using ConsoleApp9.Models;
using System.Collections;

Demo demo = new Demo();

Console.Write("Enter your name: ");
demo.SetName(Console.ReadLine());

Console.WriteLine($"\nHello, {demo.GetName()}!");

//______________________________________________________________________________
Employee test = new Employee();
string name, email;
int age, loop;

Console.Write("\n\nNumbers of employees you want to add: ");
loop = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < loop; i++)
{
    Console.Write($"\n\nEmployee's {i + 1} name: ");
    name = Console.ReadLine();

    Console.Write($"Employee's {i + 1} email: ");
    email = Console.ReadLine();

    Console.Write($"Employee's {i + 1} age: ");
    age = Convert.ToInt32(Console.ReadLine());

    test.AddEmployee(name, email, age);
}
Console.WriteLine("\n\nName\t\temail\t\t\t\tage\n______________________________________________________________");
test.GetEmployees();

//______________________________________________________________________________
Console.WriteLine($"\n\nEnter your email: ");
test.EmailAddr = Console.ReadLine();
test.GetEmail();

//______________________________________________________________________________