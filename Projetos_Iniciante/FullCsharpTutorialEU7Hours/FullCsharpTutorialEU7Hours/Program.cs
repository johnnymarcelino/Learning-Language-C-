public class FullCsharp
{

    // Explicitly

    //float price = 3.99f;
    //string name = "Jannick";
    //char letter = 'a';
    //int number = 10000;
    //bool toggle = false;

    //public static void Main(string[] args)
    //{

    //    //float productA = 3.123f;
    //    //float productB = 3.124f;
    //    //Console.WriteLine(productA);
    //    //Console.WriteLine(productB);

    //    // Implicitly

    //    //var username = 10000000000;
    //    //Console.WriteLine(username);

    //    //WriteSomething();
    //    //WriteSomethingSpecific("I am a argument and called from a method");
    //    //Console.ReadKey();

    //    //Console.WriteLine(Add(Add(10, 40), Add(20, 20)));
    //    //Console.WriteLine("----------");
    //    //Console.WriteLine(Add(15, 16));
    //    //Console.WriteLine("----------");
    //    //Console.Read();

    //    Console.WriteLine(Divide(25, 13));
    //    Console.ReadKey();
    //}


    // METHODS


    //public static void WriteSomething()
    //{
    //    Console.WriteLine("I am called from the a method");
    //}

    //public static void WriteSomethingSpecific(string myText)
    //{
    //    Console.WriteLine(myText);
    //}

    //public static int Add(int num1, int numb2)
    //{
    //    int a = num1 + numb2;
    //    return a;
    //}

    //public static double Divide(int num1, int num2)
    //{
    //    return num1 / num2;
    //}

    // INPUTS


    //public static void Main(string[] args)
    //{
    //    //Console.WriteLine(Calculate());
    //    Calculate();
    //}

    //public static int Calculate()
    //{
    //    Console.WriteLine("Please enter the first number");
    //    string number1Input = Console.ReadLine();
    //    Console.WriteLine("Please enter the second number");
    //    string number2Input = Console.ReadLine();

    //    int number1 = int.Parse(number1Input);
    //    int number2 = int.Parse(number2Input);

    //    int result = number1 + number2;

    //    return result;
    //}

    // EXCEPTIONS - CATCHING ERRORS 

    //public static void Main(string[] args)
    //{
    //    Console.WriteLine("Please enter a number");
    //    string userInput = Console.ReadLine();

    //    //int numb1 = 5;
    //    //int numb2 = 0;
    //    //int result;

    //    //try
    //    //{
    //    //    result = numb1 / numb2;
    //    //}
    //    //catch (DivideByZeroException)
    //    //{ 
    //    //    Console.WriteLine("Can't divide by zero!"); 
    //    //}


    //    //try
    //    //{
    //    //    int userInputAsInt = int.Parse(userInput);
    //    //}
    //    //catch (FormatException)
    //    //{
    //    //    Console.WriteLine("Format exception, please enter the correct type next time.");
    //    //}
    //    ////catch (Exception)  // global general exception 
    //    ////{
    //    ////    Console.WriteLine("general exception");
    //    ////}

    //    //catch (Exception)
    //    //{
    //    //    Console.WriteLine("Overflow Exception, the number was too long or too short an int32");
    //    //}
    //    ////int userInputAsInt = int.Parse(userInput);
    //    ////Console.WriteLine(userInputAsInt.ToString());

    //    //finally
    //    //{
    //    //    Console.WriteLine("this is called anyways!");
    //    //}

    //}

    //public static void Main(string[] strings)
    //{
    //    int num1 = 5;
    //    int num2 = 3;
    //    int num3;

    //    // unary operators
    //    Console.WriteLine("num3 is {0}", num1);

    //    bool isSunny = true;
    //    Console.WriteLine("is it sunny? {0}", !isSunny);

    //    // increment operators

    //    int num = 0;
    //    num++;
    //    Console.WriteLine("num is {0}", num);
    //    Console.WriteLine("num is {0}", num++);
    //    Console.WriteLine("num is {0}", ++num);

    //    // decrement operators


    //    num--;
    //    Console.WriteLine("num is {0}", num);
    //    Console.WriteLine("num is {0}", num--);
    //    Console.WriteLine("num is {0}", --num);

    //    int result;

    //    result = num1 + num2;
    //    Console.WriteLine("result of num1 + num2 is {0}", result);
    //    result = num2 - num2;
    //    Console.WriteLine("result of num1 - num2 is {0}", result);
    //    result = num1 / num2;
    //    Console.WriteLine("result of num1 / num2 is {0}", result);
    //    result = num1 * num2;
    //    Console.WriteLine("result of num1 * num2 is {0}", result);
    //    result = num1 % num2;
    //    Console.WriteLine("result of num1 % num2 is {0}", result);

    //    bool isLower;
    //    isLower = num1 > num2;
    //    Console.WriteLine("result of num1 < num2 is {0}", isLower);


    //    // equality operator
    //    bool isEqual;
    //    isEqual = num1 == num2;
    //    Console.WriteLine("result of num1 == num2 is {0}", isEqual);

    //    isEqual = num1 != num2;
    //    Console.WriteLine("result of num1 != num2 is {0}");

    //    // condicional operators
    //    bool isLowerAndSunny;
    //    isLowerAndSunny = isLower && isSunny;
    //    Console.WriteLine("result of isLower && isSunny is {0}", isLowerAndSunny);

    //    // condicional1 OR condicional2
    //    isLowerAndSunny = isLower || isSunny;
    //    Console.WriteLine("result of isLower || isSunny is {0}", isLowerAndSunny);

    //}

    //public static void Main(string[] strings)
    //{
    //    int temperature = -5;
    //    string stateOfMatter;

    //    stateOfMatter = temperature < 0 ? "solide" : "liquid";
    //    //Console.WriteLine("State of matter is {0}", stateOfMatter);
    //    temperature += 100;
    //    stateOfMatter = temperature > 100 ? "gas" : temperature < 0 ? "solid" : "liquid";
    //}

    //public static void Main(string[] strings)
    //{
    //    int lenghtOfText = 0;
    //    string wholeText = "";

    //    do
    //    {
    //        Console.WriteLine("Please enter the name of a friend");
    //        string nameOfFriend = Console.ReadLine();
    //        int currentLenght = nameOfFriend.Length;
    //        lenghtOfText += currentLenght;
    //        wholeText += nameOfFriend;
    //    } while (lenghtOfText < 20);
    //    Console.WriteLine("Thanks, thas was enough!" + wholeText);

    //}


    // loops -> for

    //public static void Main(string[] strings)
    //{
    //    for (int counter = 0; counter < 10; counter++)
    //    {
    //        Console.WriteLine(counter);
    //        if (counter == 3)
    //        {
    //            Console.WriteLine("At we stop!");
    //            break;
    //        }
    //        Console.WriteLine(counter);
    //    }
    //}

    public static void Main(string[] strings)
    {
        for (int counter = 0; counter < 10; counter++)
        {
            Console.WriteLine(counter);
            if (counter == 3)
            {
                Console.WriteLine("We skip the number 3!");
                continue;
            }
            Console.WriteLine(counter);
        }
    }
}
