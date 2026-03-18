using UtilityOfCar;
namespace CarObjectSpace{


    public class Car
    {   //a quick note for namespaces, putting the same namespace everywhere is like having 800 tools
        // in your truck and your happy because you have all your tools. And you drive your magic truck
        //into the living room to fix a lightbulb.

        //You bring everything with you, even if you dont need it. So for bigger projects consider using 
        // multiple namespaces for organization
        public string Model;
        public int Speed;

        public Car(string model)
        {
            this.Model = model;
            this.Speed = 0;
        }
                
        public void Accelerate()
        {
            this.Speed += 10;
        }

        public void Brake()
        {
            this.Speed -= 10;
        }
    }

}