namespace Lesson2;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Please, enter the name");
        var name = Console.ReadLine();

        Console.WriteLine($"Hello word {name}" );

        Console.WriteLine("Please, enter the age");
        var age = Console.ReadLine();
        var myLetter = "Мне " + age + " лет";
        Console.WriteLine(myLetter);
        Console.Read();
    }
}
