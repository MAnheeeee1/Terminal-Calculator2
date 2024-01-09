namespace Terminal_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Detta är en simpelt miniräknare från terminalen, skapad av Manh");
            Console.WriteLine("1. Addition\n2. Subtraktion\n3. Multiplikation\n4. Division\n5. Stäng Programmet");
            string svar = Console.ReadLine();

            while (svar != "5")
            {
                Console.WriteLine("1. Addition\n2. Subtraktion\n3. Multiplikation\n4. Division\n5. Stäng Programmet");

                switch (svar)
                {
                    case "1":
                        Console.WriteLine("Skriv in dina tal i varje rad");
                        int tal1 = int.Parse(Console.ReadLine());
                        int tal2 = int.Parse(Console.ReadLine());

                        Console.WriteLine($"{tal1} + {tal2} = {tal1 + tal2}");
                        break;
                    case "2":
                        Console.WriteLine("Skriv in dina tal i varje rad");
                        tal1 = int.Parse(Console.ReadLine());
                        tal2 = int.Parse(Console.ReadLine());

                        Console.WriteLine($"{tal1} - {tal2} = {tal1 - tal2}");
                        break;
                    case "3":
                        Console.WriteLine("Skriv in dina tal i varje rad");
                        tal1 = int.Parse(Console.ReadLine());
                        tal2 = int.Parse(Console.ReadLine());

                        Console.WriteLine($"{tal1} * {tal2} = {tal1 * tal2}");
                        break;

                    case "4":
                        Console.WriteLine("Skriv in dina tal i varje rad");
                        tal1 = int.Parse(Console.ReadLine());
                        tal2 = int.Parse(Console.ReadLine());

                        Console.WriteLine($"{tal1} / {tal2} = {tal1 / tal2}");
                        break;
                }
            }
        }
    }
}