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

    static void WorkingWithFiles()
    {
        //Define a directory path to output the files
        //starting in the user's directory
        string dir = Combine(
                GetFolderPath(SpecialFolder.Personal),"Code","Chapter09","OutputFiles"
            );

        CreateDirectory(dir);

        //Define file paths
        string textFile = Combine(dir, "Dummy.txt");
        string backupFile = Combine(dir, "Dummy.bak");
        WriteLine($"Working with: {textFile}");

        //Check if a file exists
        WriteLine($"Does it exist? {File.Exists(textFile)}");

        //Create a new text file an write a line on it
        StreamWriter textWriter = File.CreateText(textFile);
        textWriter.WriteLine("Hello, C#!");
        textWriter.Close();
        WriteLine($"Does it exist? {File.Exists(textFile)}");

        //Copy the file, and overwrite it if it already exists
        File.Copy(
                sourceFileName: textFile,
                destFileName: backupFile,
                overwrite: true);

        WriteLine($"Does {backupFile} exist? {File.Exists(backupFile)}");

        Write("Confirm the files exist, and then press ENTER: ");
        ReadLine();

        //Delete the file
        File.Delete(textFile);
        WriteLine($"Does it exist? {File.Exists(textFile)}");

        //Read from the text file backup
        WriteLine($"Reading the contents of {backupFile}");
        StreamReader textReader = File.OpenText(backupFile);
        WriteLine(textReader.ReadToEnd());
        textReader.Close();
    }
}