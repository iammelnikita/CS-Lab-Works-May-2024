using System.Collections;

namespace LabWork1_Var13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string input = Console.ReadLine();

            while (input != "$stop")
            {
                ArrayList vowels = new ArrayList() { 'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U', 'y', 'Y', 'а', 'А', 'е', 'Е', 'ё', 'Ё', 'и', 'И', 'о', 'О', 'у', 'У', 'ы', 'Ы', 'э', 'Э', 'ю', 'Ю', 'я', 'Я' };

                int i = 0;
                while (i < input.Length)
                {
                    if (vowels.Contains(input[i]))
                    {
                        input = input.Insert(i, input[i].ToString());
                        i += 2;
                    }
                    else
                    {
                        i++;
                    }
                }

                Console.WriteLine($"{input}\n");

                input = Console.ReadLine();
            }
        }
    }
}