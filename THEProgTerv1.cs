// Veres Zoltan - DZAE6I

using System;
using System.Security.Cryptography;
using System.Xml;
using static System.Net.Mime.MediaTypeNames;

namespace Main
{
    public class MainController
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Starting up engines...");
            Console.WriteLine("---------------------------------------------------------------------------------------------");

            Console.WriteLine("Executing 3rd test task...");
            TestTask3.run();
            Console.WriteLine("---------------------------------------------------------------------------------------------");

            Console.WriteLine("Executing 7th test task...");
            TestTask7.run();
            Console.WriteLine("---------------------------------------------------------------------------------------------");

            Console.WriteLine("Executing 8th test task...");
            TestTask8.run();
            Console.WriteLine("---------------------------------------------------------------------------------------------");

            Console.WriteLine("Executing 11th test task...");
            TestTask11.run();
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            
            Console.WriteLine("Executing 12th test task...");
            TestTask12.run();
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            
            Console.WriteLine("Executing 16th test task...");
            TestTask16.run();
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            
            Console.WriteLine("Executing 20th test task...");
            TestTask20.run();
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            
            Console.WriteLine("Executing 25th test task...");
            TestTask25.run();
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            
            Console.WriteLine("Executing 26th test task...");
            TestTask26.run();
            Console.WriteLine("---------------------------------------------------------------------------------------------");

            Console.WriteLine("---------------------------------------------------------------------------------------------");
            Console.WriteLine("Finished... BYE!!!");
        }
    }

    public static class TestTask3
    {
        public static void run()
        {
            Random random = new Random();
            string text_first, text_second;

            text_first = Helper.RandomString(random.Next(32));
            text_second = Helper.RandomString(random.Next(32));

            Console.WriteLine($"First text: \"{text_first}\" -- Length: {text_first.Length} characters...");
            Console.WriteLine($"Second text: \"{text_second}\" -- Length: {text_second.Length} characters...");
        }
    }

    public static class TestTask7
    {
        public static void run()
        {
            int[] numbers = { 11, 22, 33, 44, 55, 66, 77, 88, 99};
            int largest_integer_value = numbers.Max();
            int largest_integer_index = Array.IndexOf(numbers, largest_integer_value);

            Console.WriteLine($"The array: [{String.Join(", ", numbers)}]");
            Console.WriteLine($"Largest integer value in the array: {largest_integer_value} -- Index position of the value: {largest_integer_index}");
        }
    }

    public static class TestTask8
    {
        struct Alma
        {
            public string nev;
            public string szin;
            public int meret;
            public override string ToString()
            {
                return string.Format($"Nev: {nev}, Szin: {szin}, Meret: {meret}");
            }
        };

        public static void run()
        {
            Alma jonatan = new Alma(); jonatan.nev = "Jonatán"; jonatan.szin = "Piros"; jonatan.meret = 10;
            Alma golden = new Alma(); golden.nev = "Golden"; golden.szin = "Sargas"; golden.meret = 12;
            Alma green = new Alma(); green.nev = "Green"; green.szin = "Zold"; green.meret = 8;
            Alma torpe = new Alma(); torpe.nev = "Torpe"; torpe.szin = "Piros"; torpe.meret = 5;
            Alma vad = new Alma(); vad.nev = "Vad"; vad.szin = "Zold"; vad.meret = 7;

            Alma[] Almak = new Alma[] { jonatan, golden, green, torpe, vad };

            foreach (Alma alma in Almak)
            {
                Console.WriteLine($"Alma -- {alma.ToString()}");
            }
        }
    }

    public static class TestTask11
    {
        public static void run()
        {
            Console.WriteLine("Please input the result of the football match: ");

            string? user_input = Console.ReadLine();
            if (user_input == null)
            {
                Console.WriteLine($"Invalid user input: {user_input}");

                return;
            }

            int result_score = String.IsNullOrEmpty(user_input) ? 4 : Helper.stringToInt(user_input);
            string result_string;

            switch (result_score)
            {
                case 0:
                    result_string = "Lost";
                    break;
                case 1:
                    result_string = "Tie";
                    break;
                case 3:
                    result_string = "Win";
                    break;
                default:
                    result_string = "ERROR!!!";
                    break;
            };

            Console.WriteLine($"The result of the football match is: {result_score} -- {result_string}");
        }
    }

    public static class TestTask12
    {
        public static void run()
        {
            bool continue_looping = true;
            do
            {
                Console.WriteLine("Please input an even number between 10 and 100...:");
                string? user_input = Console.ReadLine();
                int user_number = Helper.stringToInt(user_input);

                if (!String.IsNullOrEmpty(user_input))
                {
                    if (user_number <= 100 && user_number >= 10)
                    {
                        if (user_number % 2 == 0)
                        {
                            Console.WriteLine("Congratulations... your input is correct!");
                            continue_looping = false;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, but the given user input needs to be an even number...");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Sorry, but the given user input needs to be between 10 and 100...");
                    }
                }
                else
                {
                    Console.WriteLine("Sorry, but the given user input seems to be empty...");
                }
            }
            while (continue_looping);
        }
    }

    public static class TestTask16
    {
        public static void run()
        {
            string[] name_list = { "Zoltán", "Dániel", "Megszentségteleníthetetlenségeskedéseitekért Magda", "Hosszú Katinka" };

            int longest_name_index = 0;
            int longest_name_length = 0;
            int current_index = 0;

            foreach (string name in name_list)
            {
                if (name.Length > longest_name_length)
                {
                    longest_name_index = current_index;
                    longest_name_length = name.Length;
                }

                current_index++;
            }

            Console.WriteLine($"The longest name is: {name_list[longest_name_index]}");
            Console.WriteLine($"The longest name index is: {longest_name_index}");
        }
    }

    public static class TestTask20
    {
        public static void run()
        {

        }
    }

    public static class TestTask25
    {
        public static void run()
        {
            Console.WriteLine("Please input a file name with path:...");
            string? file_path = Console.ReadLine();
            if (String.IsNullOrEmpty(file_path))
            {
                file_path = "C:\\Users\\Admin\\Desktop\\projects\\THE\\Programozas modszertana\\THEProgTerv1\\lorem.txt";
            }

            string text = System.IO.File.ReadAllText(@file_path);
            System.Console.WriteLine($"Contents of file: {@file_path}");
            System.Console.Write(text);
        }
    }

    public static class TestTask26
    {
        public static async Task run()
        {
            Random random = new Random();
            string szoveg = Helper.RandomString(random.Next(32));
            int szam = Helper.RandomNumber(random.Next(32000));

            Console.WriteLine($"Outputting the following string: \"{szoveg}\"");
            Console.WriteLine($"Outputting the following number: \"{szam}\"");

            await File.WriteAllTextAsync(
                "C:\\Users\\Admin\\Desktop\\projects\\THE\\Programozas modszertana\\THEProgTerv1\\adatok.txt",
                $"{szoveg} -- {szam}"
            );

            using (BinaryWriter binary_writer = new BinaryWriter(File.Open(
              @"C:\\Users\\Admin\\Desktop\\projects\\THE\\Programozas modszertana\\THEProgTerv1\\bin.bin",
              FileMode.Create)))
            {
                binary_writer.Write($"{szoveg} -- {szam}");
            }
        }
    }

    public class Bútor
    {
        string megnevezes { get; set; }
        string alapanyag { get; set; }
        string rendeltetes { get; set; }
        float ar { get; set; }

        public Bútor(
            string megnevezes,
            string alapanyag,
            string rendeltetes,
            float ar
        ) {
            this.megnevezes = megnevezes;
            this.alapanyag = alapanyag;
            this.rendeltetes = rendeltetes;
            this.ar = ar;
        }
    }

    public interface ILapraszerelt
    {
        public string getOsszeszerelesiUtasitas();
    }

    public class Lapraszerelt: ILapraszerelt
    {
        public string osszeszerelesi_utasitas;
        public Lapraszerelt(string osszeszerelesi_utasitas)
        {
            this.osszeszerelesi_utasitas = osszeszerelesi_utasitas;
        }

        public string getOsszeszerelesiUtasitas()
        {
            return this.osszeszerelesi_utasitas;
        }
    }

    public static class Helper
    {

        private static Random random = new Random();

        //https://stackoverflow.com/questions/1344221/how-can-i-generate-random-alphanumeric-strings
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static int RandomNumber(int max)
        {
            return random.Next(max);
        }

        public static int stringToInt(string? variable)
        {
            if (variable is null) {
                return 0;
            }

            try
            {
                return Int32.Parse(variable);
            }
            catch
            {
                return 0;
            }
        }

    }
}
