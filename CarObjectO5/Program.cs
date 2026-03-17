using System;
using CarObjectSpace;
public class Program
{
    public static void Main(/* string model, int speed  */)
    {
        Car car = new Car();
        Console.WriteLine("What's your favorite Car?");
        car.model = Console.ReadLine();

        Console.WriteLine($"Let's take a {car.model} for a spin!");
        car.Accelerate();
        Console.WriteLine($"Speed is at: {car.speed} miles per hour!");
        
        car.Accelerate();
        Console.WriteLine($"Speed is at: {car.speed} miles per hour!");
        
        car.Brake();
        Console.WriteLine($"Speed is at: 70 nah im just kidding pump the breaks");
        Console.WriteLine($"Speed: {car.speed}");
        



        /* 
        Main must:

        Ask the user for a car model
        Create one Car object using new
        Call Accelerate() twice
        Call Brake() once
        Display the car’s speed after each method call

        Car.cs must be in a different namespace than Program.cs
        */
    }
}