using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace idiotPet;
public class idiotPet
{
    private int hunger = 30;
    private int boredom = 40;
    private List<string> words;
    private bool isAlive;
    private Random Generator;
    public string Name;
    public string choice = Console.ReadLine();
    public string teachWord;
    public int tick;


    public void Feed()
    {
        if ( choice == "feed")
        {
            hunger += 10;
        }
    }

    public void Hi()
    {
        if (choice == "Hi")
        {
            Console.WriteLine(words);
        }
    }

    public void Teach(int word)
    {
        if (choice == "Teach")
        {
            Console.WriteLine("What word do you want to teach it??");
            teachWord = Console.ReadLine();
            words.Add(teachWord);
        }
    }

    public void Tick()
    {
        if (choice == "feed" || choice == "Hi" || choice == "Teach" || choice == "Print stats")
        {
            tick += 1;
            if (tick > 3)
            {
                boredom += 20;
                hunger += 20;
            }
        }
    }

    public void PrintStats()
    {
        if (choice == "Print stats")
        {
            Console.WriteLine(hunger);
            Console.WriteLine(boredom);
            Console.WriteLine(isAlive);
        }
    }

    public bool getAlive()
    {
        return true;
    }

    private void reduceBoredom()
    {
        if (choice == "Teach" || choice == "Hi")
        {
            boredom -= 10;
        }
    }
}
