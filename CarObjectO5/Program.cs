using System;
using CarObjectSpace;
using UtilityOfCar;
public class Program
{
    public static void Main(/* string model, int speed  */)
    {
        Console.WriteLine("Enter car model:");
        string model = Console.ReadLine() ?? string.Empty;
        Car car = new Car(model);

       // Console.WriteLine($"Let's take a {car.Model} for a spin!");
        car.Accelerate();
        //Console.WriteLine($"Speed: {car.Speed}");
        CarUtilities.DisplayCar(car); //this is okay because the using space
            // brings it in for easier calling on it, then we just specify the car

        car.Accelerate();
         CarUtilities.DisplayCar(car);
        
        car.Brake();
        Console.WriteLine($"Oy bruv pump the brakes");
        CarUtilities.DisplayCar(car);
        Console.WriteLine($"Woah there bruv that was a wild ride");



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