using System;

public interface IOperation
{
    int Execute(int a, int b);
}

public class Plus : IOperation
{
    public int Execute(int a, int b)
    {
        return a + b;
    }
}

public class Minus : IOperation
{
    public int Execute(int a, int b)
    {
        return a - b;
    }
}

public class Krat : IOperation
{
    public int Execute(int a, int b)
    {
        return a * b;
    }
}

public class Deleno : IOperation
{
    public int Execute(int a, int b)
    {
        return a / b;
    }
}

public class Kalkulacka
{
    private IOperation _operation;

    public Kalkulacka(IOperation operation)
    {
        _operation = operation;
    }

    public int ExecuteOperation(int a, int b)
    {
        return _operation.Execute(a, b);
    }
}

class CalculatorApp
{
    static void Main()
    {
        Console.Write("Zadej číslo: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Zadej další číslo: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Zadej operaci (+ / - / * / :): ");
        string selectedOp = Console.ReadLine();

        IOperation op;

        if (selectedOp == "+")
        {
            op = new Plus();
        }
        else if (selectedOp == "-")
        {
            op = new Minus();
        }
        else if (selectedOp == "*")
        {
            op = new Krat();
        }
         else if (selectedOp == "/")
        {
            op = new Deleno();
        }
        else
        {
            Console.WriteLine("Neplatná operace");
            return;
        }

        Kalkulacka calculator = new Kalkulacka(op);
        Console.Write($"Výsledek je {calculator.ExecuteOperation(a, b)}");
        Console.ReadLine();
    }
}
