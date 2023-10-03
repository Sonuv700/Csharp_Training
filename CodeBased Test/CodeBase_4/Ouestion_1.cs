using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        // Specify the file path
        string filePath = "example.txt";

        try
        {
            // Create a StreamWriter with the specified file path in Append mode
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                // Prompt the user for text to append
                Console.Write("Enter text to append to the file: ");
                string textToAppend = Console.ReadLine();

                // Write the text to the file
                writer.WriteLine(textToAppend);
                Console.WriteLine("Text appended successfully!");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}

