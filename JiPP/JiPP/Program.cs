using System;

class Program
{
    static void Main()
    {
        // Zadanie 2
        Console.WriteLine("Podaj swoje imię:");
        var name = Console.ReadLine();
        Console.WriteLine("Hello " + name);

        // Zadanie 3
        int result = 5 + 9;
        Console.WriteLine("Wynik: " + result);

        // Operatory - Zadanie 1
        int number = 10;
        double money = 1.4;
        string text = "test";
        bool isLogged = true;
        char myChar = 'T';
        decimal price = 3.22m;

        Console.WriteLine($"Number: {number}, Money: {money}, Text: {text}, Logged: {isLogged}, Char: {myChar}, Price: {price}");

        // Operatory - Zadanie 2
        string myAge = "Age: ";
        int wifeAge = 18;
        string result2 = myAge + wifeAge; 
        Console.WriteLine(result2);
       

        // Operatory - Zadanie 3
        bool isTrue = true;
        bool isFalse = false;
        bool isReallyTrue = true;

        bool and = isTrue && isFalse;
        bool or = isTrue || isReallyTrue;
        bool negative = !isFalse;

        Console.WriteLine($"AND: {and}, OR: {or}, NEGATION: {negative}");

        // Operatory - Zadanie 4
        int a = 5, b = 12;
        int add = a + b;
        int sub = a - b;
        int div = a / b;
        int mul = a * b;
        int mod = a % b;

        Console.WriteLine($"Add: {add}, Sub: {sub}, Div: {div}, Mul: {mul}, Mod: {mod}");

        // Operatory - Zadanie 5
        string sa = "Ala ";
        string sb = "ma ";
        string sc = "kota.";

        string result3 = sa + sb + sc;
        Console.WriteLine(result3);
        //3 zmienne typu string łaczą się w jeden ciąg znaków
    }
}
