namespace Chapter04;

public class ImmutablePerson
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

public record ImmutableVehicle
{
    public int Wheels { get; init; }
    public string? Color { get; init; }
    public string? Brand { get; init; }
}

public class ImmutableAnimals
{
    public string Name { get; init; }
    public string Species { get; set; }

    public ImmutableAnimals(string name, string species)
    {
        Name = name;
        Species = species;
    }

    public void Deconstruct(out string name, out string species)
    {
        name = Name;
        species = Species;
    }

    //Simpler way to define a record
    //auto-generates the properties, constructor, deconstructor
    public record ImmutableAnimal(string Name, string Species);
}