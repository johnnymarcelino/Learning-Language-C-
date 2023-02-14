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

        //WriteSomething();
        //WriteSomethingSpecific("I am a argument and called from a method");
        //Console.ReadKey();

        //Console.WriteLine(Add(Add(10, 40), Add(20, 20)));
        //Console.WriteLine("----------");
        //Console.WriteLine(Add(15, 16));
        //Console.WriteLine("----------");
        //Console.Read();

        Console.WriteLine(Divide(25, 13));
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
        int a = num1 + numb2;
        return a;
    }

    public static double Divide(int num1, int num2)
    {
        return num1 / num2;
    }

}
