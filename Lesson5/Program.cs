
/*using System;
class Car
{
    public string model;
    public string color;
    public int year;
    public  int b = 10000;

    public Car (string model, string color, int year)
    {
        this.model = model;
        this.color = color;
        this.year = year;
    }
    public void showInfo()
    {
        Console.WriteLine($"Model: {model}, color: {color}, year: {year}");
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Car audi = new Car("A4", "red", 2024);
        audi.showInfo();
        audi.model = "A7";
        audi.showInfo();
*//*        audi.color = "red";
        audi.model = "A4";
        audi.year = 2020;

Car opel = new Car();
        opel.color = "red";
        opel.year = 2018;
        opel.model = "Omega";
        opel.showInfo();*//*
    }
}*/


using System;

class Person
{
    public string name;
    public string secondName;
    public int age;
    public int id;
    public int balance;
    public Person(string name, string secondName, int age, int id)
    {
        this.name = name;
        this.secondName = secondName;
        this.age = age;
        this.id = id;
        this.balance = 1000;
    }
    public void ShowInfo()
    {
        Console.WriteLine($"Name: {name},Second Name: {secondName},Age: {age},ID: {id},Balance: {balance}");
    }
    public void ZnatieKesh(int sum)
    {
        if (sum > balance)
        {
            Console.WriteLine("Nema koshtiv!");
        }
        else
        {
            balance -= sum;
            Console.WriteLine($"Znjalu: {sum}. Zalushok: {balance}");
        }
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Person user = new Person("Roma", "Litvi", 30, 12345);
        user.ShowInfo();
        user.ZnatieKesh(200);
        user.ZnatieKesh(1000);
    }
}

