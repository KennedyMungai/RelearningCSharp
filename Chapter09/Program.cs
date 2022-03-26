using static System.Console;
using static System.IO.Directory;
using static System.IO.Path;
using static System.Environment;

namespace Chapter09;

public class Program
{
    public static void Main(string[] args)
    {
        WorkingWithDirectories();
    }

    static void WorkingWithDirectories()
    {
        //define a directory path for a new folder
        //starting in the user's folder
        string newFolder = Combine(
                GetFolderPath(SpecialFolder.Personal),
                "Code", "Chapter09", "NewFolder");

        WriteLine($"Working with: {newFolder}");

        //Check if it exists
        WriteLine($"Does it exist? {Exists(newFolder)}");

        //Create a directory
        WriteLine("Creating it ....");
        CreateDirectory(newFolder);
        WriteLine($"Does it exist? {Exists(newFolder)}");
        Write("Confirm the directory exists and then press ENTER.");
        ReadLine();

        //Delete directory
        WriteLine("Deleting it....");
        Delete(newFolder, recursive: true);
        WriteLine($"Does it exist? {Exists(newFolder)}");
    }
}