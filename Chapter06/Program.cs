using static System.Console;

namespace Chapter06;

public class Chapter06
{
    public static void Main(string[] args)
    {
        Person[] people =
        {
            new(){Name = "Simon"},
            new(){Name = "Jenny"},
            new(){Name = "Adam"},
            new(){Name = "Richard"}
        };

        WriteLine("Initial list of people:");
        WriteLine("-----------------------------------------------------------------");

        foreach (Person p in people)
        {
            WriteLine(p.Name);
        }

        WriteLine();
        WriteLine("Use Person's IComparable implementation to sort:");
        WriteLine("-----------------------------------------------------------------");
        Array.Sort(people);

        foreach (Person p in people)
        {
            WriteLine(p.Name);
        }

        WriteLine();
        WriteLine("Use PersonComparer's IComparer implemetation to sort: ");
        WriteLine("-----------------------------------------------------------------");
        Array.Sort(people, new PersonComparer());

        foreach (Person p in people)
        {
            WriteLine(p.Name);
        }

        DisplacementVector dv1 = new(3, 5);
        DisplacementVector dv2 = new(-2, 7);
        DisplacementVector dv3 = dv1 + dv2;

        WriteLine($"({dv1.X}, {dv2.X}) + ({dv1.Y}, {dv2.Y}) = ({dv3.X}, {dv3.Y})");

        Employee john = new()
        {
            Name = "John Jones",
            DateOfBirth = new(year: 1990, month: 07, day: 28)   
        };

        john.WriteToConsole();
        john.EmployeeCode = "JJ001";
        john.HireDate = new(year: 2014, month: 11, day: 23) ;

        WriteLine(john.ToString());
    }
}