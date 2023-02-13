public class FullCsharp
{

    // Explicitly

    //float price = 3.99f;
    //string name = "Jannick";
    //char letter = 'a';
    //int number = 10000;
    //bool toggle = false;

    public static void Main()
    {

        //float productA = 3.123f;
        //float productB = 3.124f;
        //Console.WriteLine(productA);
        //Console.WriteLine(productB);

        // Implicitly

        //var username = 10000000000;
        //Console.WriteLine(username);

        WriteSomething();
        WriteSomethingSpecific("I am a argument and called from a method");
        Console.ReadKey();
    }

    public static void WriteSomething()
    {
        Console.WriteLine("I am called from the a method");
    }

    public static void WriteSomethingSpecific(string myText)
    {
        Console.WriteLine(myText);
    }

    public static int Add(int num1, int numb2)
    {
        int a = 12;
        return a;
    }
}
