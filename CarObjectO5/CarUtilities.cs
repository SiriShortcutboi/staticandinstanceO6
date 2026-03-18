using CarObjectSpace;
//namespace CarObjectSpace{

namespace UtilityOfCar
{
    public static class CarUtilities
    {
        public static void DisplayCar(Car car)
        {   
            Console.WriteLine($"We are sitting in a {car.Model}. How fancy.");
            Console.WriteLine($"Currently we're moving at {car.Speed} American"
            + " Miles per hour. Cheerio");
        }


    }

}

//}