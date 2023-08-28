using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{

    public class Employee

    {
        public string name;
        public int age;
        public float salary;
        public Employee(string name, int age, float salary)
        {
            this.name = name;
            this.age = age;
            this.salary = salary;


        }
        public void display()
        {
            Console.WriteLine("Name is: {0} \nAge is: {1} \nSalary is: {2}", name, age, salary);
            Console.ReadLine();
        }
       
    }
    public class BankAccount
    {
        int account_number;
        string name;
        float balance;
        public BankAccount(int account_number,string name,float balance)
        {
            this.account_number = account_number;
            this.name = name;
            this.balance = balance;
        }
        public void deposit(int amount)
        {
            balance += amount;
        }
        public void withdrawal(int amount)
        {
            if(balance>0)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient amount");
            }
        }
        public void display()
        {
            Console.WriteLine("Name is: {0} \nAccount number is: {1} \nBalance is: {2}", name, account_number,balance);
            Console.ReadLine();
        }
    }
    public static class MathHelper
    {
        public static float CalculateAverage(int[] arr)
        {
            int sum = 0;
            foreach(int num in arr)
            {
                sum+=num;
            }
            return (float)sum / arr.Length;
        }
    }

    public static class Logger
    {
        public static void LogMessage()
        {
            Console.WriteLine("Hello! this is log message");
            Console.ReadLine();
        }
    }

    public partial class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    public partial class Person
    {
        public void PrintFullName()
        {
            string fullName = $"{FirstName} {LastName}";
            Console.WriteLine($"Full Name: {fullName}");
            Console.ReadLine();
        }
    }

    public partial class p_Employee
    {
        string p_name;
        int p_age;
        public p_Employee(string name,int age)
        {
           p_name = name;
           p_age = age;
        }
    }
    public partial class p_Employee
    {
        public void Display()
        {
            Console.WriteLine("Name: {0}\nAge: {1}", p_name, p_age);
            Console.ReadLine();
        }
    }

    public abstract class Shape
    {
        public abstract void CalculateArea();
    }
    class Circle : Shape
    {
        double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override void CalculateArea()
        {
            double area = 3.14 * radius * radius;
            Console.WriteLine("Area of Circle is: {0}",area);
            Console.ReadLine();
        }
    }
    class Rectangle : Shape
    {
        double length,breadth;
        public Rectangle(double length,double breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }
        public override void CalculateArea()
        {
            double area = length*breadth;
            Console.WriteLine("Area of Rectangle is: {0}", area);
            Console.ReadLine();
        }
    }

    abstract class Animal
    {
        public abstract void Sound();
    }
    class Dog:Animal 
    { 
        public override void Sound()
        {
            Console.WriteLine("Bark");
            Console.ReadLine();
        }
    }
    class Cat : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Meow");
            Console.ReadLine();
        }
    }

    public class Vehicle
    {
        public void StartEngine()
        {
            Console.WriteLine("Engine started");
            Console.ReadLine();
        }
        public void StopEngine()
        {
            Console.WriteLine("Engine Stopped");
            Console.ReadLine();
        }
    }
    sealed class Car:Vehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving");
            Console.WriteLine("Cannot derive car in any other class");
            Console.ReadLine();
        }
    }
    public class p_BankAccount
    {
        int account_number;
        int balance;
        
    }
    sealed class SavingAccount:p_BankAccount
    {
        public void interest()
        {
            Console.WriteLine(23000);
            Console.ReadLine();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Employee e = new Employee("Munendra Kushwaha", 23, 1000000);
            // e.display();


            //BankAccount bank = new BankAccount(123456, "Munendra", 1000);
            //bank.display();
            //bank.deposit(5000);
            //bank.withdrawal(2500);
            //bank.display();

            //int[] numbers = { 1, 2, 3, 4, 5, 6 };
            //Console.WriteLine(MathHelper.CalculateAverage(numbers));
            //Console.ReadLine();

            //Logger.LogMessage();

            //Person person = new Person();
            //person.FirstName = "Munendra";
            //person.LastName = "Kushwaha";
            //person.PrintFullName();

            //p_Employee emp = new p_Employee("Munendra", 23);
            //emp.Display();

            //Circle circle = new Circle(10);
            //circle.CalculateArea();
            //Rectangle rectangle = new Rectangle(10, 20);
            //rectangle.CalculateArea();

            //Dog dog = new Dog();
            //dog.Sound();
            //Cat cat = new Cat();
            //cat.Sound();

            //Car car = new Car();
            //car.StartEngine();
            //car.StopEngine();
            //car.Drive();

            //SavingAccount saving = new SavingAccount();
            //saving.interest();
        }
    }
}
