using System;

namespace More_OOP
{
    class Program
    {
        class Car
        {
            public string model;  // Create a field
            public string color;

            //Create a class constructor for the Car class
            //Note that the constructor name must match the class name, 
            //and it cannot have a return type(like void or int).
            public Car()
            {
                model = "Mustang"; // Set the initial value for model
                color = "Red";
            }

            static void Main(string[] args)
            {
                //Also note that the constructor is called when the object is created new Car.Car().
                Car Ford = new Car();  // Create an object of the Car Class (this will call the constructor)
                Console.WriteLine(Ford.model);  // Print the value of model
                Console.WriteLine(Ford.color);
            }
        }
    }
}



//All classes have constructors by default: if you do not create a class constructor yourself, C# creates one for you. However, then you are not able to set initial values for fields.
