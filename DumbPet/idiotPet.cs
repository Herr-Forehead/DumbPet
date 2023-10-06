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

    public void Teach()
    {
        if (choice == "Teach")
        {
            teachWord = Console.ReadLine();
            words.Add(teachWord);
        }
    }

    public void Tick()
    {
        // igu
    }

    public void PrintStats()
    {
        // uyf
    }

    public bool getAlive()
    {
        return true;
    }

    private void reduceBoredom()
    {
        // uyvuyhvf
    }
}
