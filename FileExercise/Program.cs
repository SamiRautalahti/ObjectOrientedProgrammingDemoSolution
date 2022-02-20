using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string filePath = @"C:\Users\sampp\Source\Repos\SamiRautalahti\ObjectOrientedProgrammingDemoSolution\FileExercise\testfile.txt";

            FileManager fm = new FileManager(filePath);
            string text = fm.ReadWords();
            Console.WriteLine(text);

            WriteFile();
            ReadFile();
            WriteJsonFile();
            ReadJsonFile();
        }

            static void WriteFile()
            {
                Console.WriteLine("\nWriting to file data.txt");

                const string path = @"C:\Users\sampp\Source\Repos\SamiRautalahti\ObjectOrientedProgrammingDemoSolution\FileExercise\data.txt";

                // File.Exists(string path);
                if (File.Exists(path))
                {
                string[] createText = { "Hello", "And", "Welcome" };
                File.WriteAllLines(path, createText, Encoding.UTF8);
                // File.WriteAllLines(string path, string[] contents, System.Text.Encoding encoding);

                string appendText = "This is extra text" + Environment.NewLine;
                File.AppendAllText(path, appendText, Encoding.UTF8);
                // File.AppendAllText(string path, string contents);
            }

            

        }

            static void ReadFile()
            {
            Console.WriteLine("\nReading file data.txt");

            const string path = @"C:\Users\sampp\Source\Repos\SamiRautalahti\ObjectOrientedProgrammingDemoSolution\FileExercise\data.txt";

            // File.ReadAllLines(string path);
            if (File.Exists(path))
                {
                string[] readText = File.ReadAllLines(path, Encoding.UTF8);
                foreach (string s in readText)
                {
                    Console.WriteLine(s);
                }
                
            }

        }

        static void WriteJsonFile()
        {
            Console.WriteLine("\nWriting Json data to books.txt file");

            const string jsonFile = @"C:\Users\sampp\Source\Repos\SamiRautalahti\ObjectOrientedProgrammingDemoSolution\FileExercise\books.txt";

            List<Book> bookList = new List<Book>();
            bookList.Add(new Book()
            {
                title = "Fingerpori I",
                author = "Pertti Jarla",
                id = "9789511355137",
                price = 17.95
            });
            bookList.Add(new Book()
            {
                title = "Fingerpori II",
                author = "Pertti Jarla",
                id = "9789511355138",
                price = 19.95
            });
            bookList.Add(new Book()
            {
                title = "Fingerpori III",
                author = "Pertti Jarla",
                id = "9789511355139",
                price = 21.95
            });
            bookList.Add(new Book()
            {
                title = "Fingerpori IV",
                author = "Pertti Jarla",
                id = "9789511355140",
                price = 23.95
            });
            // JsonConvert.SerializeObject(Object value);
            File.WriteAllText(@"C:\Users\sampp\Source\Repos\SamiRautalahti\ObjectOrientedProgrammingDemoSolution\FileExercise\books.json", JsonConvert.SerializeObject(bookList));
            
        }
            //Vaihtoehtoinen tapa lisätä kirjat:
            //List<Book> booklist = new List<Book>();
            //booklist.Add(new Book("Fingerpori I", "Pertti Jarla", "9789511355137", 17.95));
            //booklist.Add(new Book("Fingerpori II", "Pertti Jarla", "9789511355138", 19.95));
            //booklist.Add(new Book("Fingerpori III", "Pertti Jarla", "9789511355139", 21.95));
            //booklist.Add(new Book("Fingerpori IV", "Pertti Jarla", "9789511355140", 23.95));



            // File.WriteAllText(string path, string contents);
  
            
                // Create a file to write to.
                

            // This text is always added, making the file longer over time
            // if it is not deleted.
           

            

            // Serialize JSON to a file
            // https://www.newtonsoft.com/json/help/html/SerializeWithJsonSerializerToFile.htm

        

            static void ReadJsonFile()
            {
                Console.WriteLine("\nReading Json data from books.txt file");

            // File.ReadAllText(string path, E
            List<Book> books = JsonConvert.DeserializeObject<List<Book>>(File.ReadAllText(@"C:\Users\sampp\Source\Repos\SamiRautalahti\ObjectOrientedProgrammingDemoSolution\FileExercise\books.json", Encoding.UTF8));
            String path = @"C:\Users\sampp\Source\Repos\SamiRautalahti\ObjectOrientedProgrammingDemoSolution\FileExercise\books.json";

            String[] lines;
            lines = File.ReadAllLines(path);

            Console.WriteLine(lines[0]);

            
            /*
            if (File.Exists("books.json"))
            {
                string content = File.ReadAllText("books.json");
                Console.WriteLine("Current content of file:");
                Console.WriteLine(content);
            }

            //Console.ReadKey();
            Console.WriteLine("________________________________________");
            */
            


            Console.ReadLine();
            }
        }
    }
