using System;

namespace car_and_vehicle_Covariance_and_Contravariance
{
    class Vehicle
    { 
    
    }

    class Car : Vehicle
    { 
    
    }
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle v1 = new Car();
            Vehicle v2 = new Car();

            Func<Vehicle> func = GetVehicle;
            Vehicle v3 = func();

            Action<Car> action = parkvehicle;
            action(new Car());
        }

        static Car GetVehicle()
        {
            return new Car();
        }

        static void parkvehicle(Vehicle vehicle)
        { 
        
        }
    }
}
