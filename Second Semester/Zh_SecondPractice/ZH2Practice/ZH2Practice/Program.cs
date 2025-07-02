namespace ZH2Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


        }

        public static string[] ReadFile(string path)
        {
            string[] lines = File.ReadAllLines(path);
            for (int i = 0; i< lines.Length; i++)
            {
                lines[i] = lines[i + 1];
            }
            Array.Resize(ref lines, lines.Length-1);

            return lines;
        }

        public static Races ReadFolder(string path)
        {
            string[] files = Directory.GetFiles(path, "*.txt");

            Races races = new Races(new RaceResults[files.Length]);

            for (int i = 0; i < files.Length; i++)
            {
                string []lines =ReadFile(files[i]);

                races.race[i]= new RaceResults(lines.Length, lines);
            }
            return races;
        }
    }
}
