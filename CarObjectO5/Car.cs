namespace CarObjectSpace;


public class Car
{   //a quick note for namespaces, putting the same namespace everywhere is like having 800 tools
    // in your truck and your happy because you have all your tools. And you drive your magic truck
    //into the living room to fix a lightbulb.

    //You bring everything with you, even if you dont need it. So for bigger projects consider using 
    // multiple namespaces for organization
    public string Model;
    public int speed; 

                                //i think static probably breaks assignment rules but                                    
    public Car()// maybe not
    {
        Model = model;  
        speed = 0;

        //speed import not needed because we are doing our own thing with speed in here
    }
            
    public int Accelerate()
    {
        speed += 10;
        return speed;
    }
    public int Brake()
    {
        speed -= 10;
        return speed;
    }


    
    
}