using System;

namespace More_OOP
{
    class Program
    {
        class Car
        {
            public string model;  // Create a field
            public string color;

            // Create a class constructor for the Car class
            public Car()
            {
                model = "Mustang"; // Set the initial value for model
                color = "Red";
            }

            static void Main(string[] args)
            {
                Car Ford = new Car();  // Create an object of the Car Class (this will call the constructor)
                Console.WriteLine(Ford.model);  // Print the value of model
                Console.WriteLine(Ford.color);
            }
        }
    }
}
