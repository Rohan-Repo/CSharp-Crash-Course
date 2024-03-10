// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;

Console.WriteLine("Hello, World!");


void greetUser( string name, int age, double weight )
{
    Console.WriteLine( "\n In greetUser(): " );
    Console.WriteLine( $"\t Hello, {name} : {age} - {weight}" );
}

string name = "Rohan";
int age = 31;
double weight = 90.5;
DateTime today = DateTime.Now;

Console.WriteLine( "\n Explicitly Typed Variable - Specify the exact Data-type " );
Console.WriteLine("\t int age - " + age + " : " + age.GetType() );
Console.WriteLine("\t string name - " + name + " : " + name.GetType() );
Console.WriteLine("\t double weight - " + weight + " : " + weight.GetType() );
Console.WriteLine("\t DateTime today - " + today + " : " + today.GetType());

greetUser( name, age, weight );

var name2 = "John Doe";
var age2 = 45;
var weight2 = 60.65;
var today2 = DateTime.Today;

Console.WriteLine("\n Implicitly Typed Variable : Compiler Finds out the Data-Type at Runtime!" );
Console.WriteLine("\t var age2 - " + age2 + " : " + age2.GetType());
Console.WriteLine("\t var name2 - " + name2 + " : " + name2.GetType());
Console.WriteLine("\t var weight2 - " + weight2 + " : " + weight2.GetType());
Console.WriteLine("\t var today2 - " + today2 + " : " + today2.GetType());

greetUser(name2, age2, weight2);

string frnd_1 = "John Doe";
string frnd_2 = "Jane Doe";

//With String interpolation we can get the values as well as run methods or get properties on our variables
Console.WriteLine("\n");
Console.WriteLine($"Friend #1 - {frnd_1} \t Friend #2 - {frnd_2} ");
Console.WriteLine($"Friend #1 - {frnd_1.ToUpper()} \t Friend #2 - {frnd_2.ToLower()} ");
Console.WriteLine($"Friend #1 - {frnd_1.Length} \t Friend #2 - {frnd_2.Length} ");

/* 
    Create User-Defined Data-types using record, struct or classes:
    records: just to create Getters and Setters but they are immutable - Cannot be changed  
    objects are stored in heap memory and given a pointer to that object
    struct: to store primitive data-types, exists on the execution stack of the program - runs on the memory provided for your thread - so really useful for small data-types - to have readily accesible values for small data-types in memory
    classes: normal OOPS like object, methods, properties, has 5 access modifiers:
        - public : visible and accessible everywhere
        - private : visible and accessible to only the scope 
        - protected : visible and accessible to class and it's children
        - internal : visible and accessible in the assembly
        - file : visible and accessible in just this file
    classes can be inherited, abstract to inherit
*/

    //private record Student(Guid studID, string studName, int studSem);

    //// var student_1 = new(studID: Guid.NewGuid(), studName: "Jane Doe", studSem: 1);
    //Student student_1 = new( Guid.NewGuid(), "Jane Doe", 1 );
    //// var student = new (Guid.NewGuid(), "Jane Doe", 1);
