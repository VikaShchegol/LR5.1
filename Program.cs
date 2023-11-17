using System;

abstract class Parent
{
    protected double pole1;

    public Parent(double a)
    {
        pole1 = a;
    }

    public abstract string Info();
    public abstract double Metod1();
    public abstract double Metod2();
}

class Child1 : Parent
{
    public Child1(double a) : base(a) { }

    public override string Info()
    {
        return $"Тетраедр: a = {pole1}";
    }

    public override double Metod1()
    {
        return Math.Sqrt(3) * pole1 * pole1;
    }

    public override double Metod2()
    {
        return Math.Pow(pole1, 3) / (6 * Math.Sqrt(2));
    }
}

class Child2 : Parent
{
    public Child2(double a) : base(a) { }

    public override string Info()
    {
        return $"Куб: a = {pole1}";
    }

    public override double Metod1()
    {
        return 6 * pole1 * pole1;
    }

    public override double Metod2()
    {
        return Math.Pow(pole1, 3);
    }
}

class Program
{
    static void Main()
    {
        Random random = new Random();

        for (int i = 0; i < 5; i++)
        {
            double a = random.Next(1, 11); 
            bool isTetrahedron = random.Next(0, 2) == 0;

            Parent obj;
            if (isTetrahedron)
            {
                obj = new Child1(a);
            }
            else
            {
                obj = new Child2(a);
            }

            Console.WriteLine(obj.Info());
            Console.WriteLine($"S = {obj.Metod1():F2}");
            Console.WriteLine($"V = {obj.Metod2():F2}");
            Console.WriteLine();
        }
    }
}
