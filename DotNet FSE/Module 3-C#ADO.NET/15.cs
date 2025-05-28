using System;

abstract class Vehicle
{
    public abstract void Drive();
}

interface IDrivable
{
    void Start();
}

class Car : Vehicle, IDrivable
{
    public override void Drive()
    {
        Console.WriteLine("Driving the car");
    }

    public void Start()
    {
        Console.WriteLine("Car started");
    }
}

class Program
{
    static void Main()
    {
        Car myCar = new Car();
        myCar.Start();
        myCar.Drive();

        Vehicle vehicle = myCar;
        vehicle.Drive();

        IDrivable drivable = myCar;
        drivable.Start();
    }
}
