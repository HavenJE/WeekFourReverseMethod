

// Week 4 - Reverse method 

class Program
{
    static void Main()
    {
        string[] randomeName = {"Rami", "Sami", "Ali", "Salama" };
        int i;

        Array.Reverse(randomeName);
        for (i = 0; i < randomeName.Length; i++)
        {
            Console.WriteLine(randomeName[i]);
        }
    }
}