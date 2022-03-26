using System;

using static System.Console;

namespace Chapter04;

class Chapter04
{
    static void Main(string[] vs)
    {
        /*Person alice = new()
        {
            Name = "Alice",
            DateOfBirth = new DateTime(1990, 05, 28)
        };

        WriteLine(alice.Name);
        WriteLine(alice.DateOfBirth);

        WondersOfTheAncientWorld favouriteWonder = WondersOfTheAncientWorld.GreatPyramidOfGiza;

        WriteLine(favouriteWonder);*/

        ImmutablePerson jeff = new()
        {
            FirstName = "jeff",
            LastName = "Winger"
        };

        jeff.FirstName = "Geoff";

        WriteLine(jeff.FirstName);

        ImmutableVehicle car = new()
        {
            Brand = "Mazda MX-5 RF",
            Color = "Soul Red Crystal Metallic",
            Wheels = 4
        };

        ImmutableVehicle repaintedCar = car with { Color = "Polymetal Grey Metallic" };

        WriteLine($"Original car color was {car.Color}");
        WriteLine($"The new car color is {repaintedCar.Color}");

        ImmutableAnimals oscar = new("Oscar", "Labrador");
        var (who, what) = oscar;                //calls a deconstruct method
        WriteLine($"{who} is a {what}");
    }
}