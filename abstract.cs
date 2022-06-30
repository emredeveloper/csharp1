abstract class newanimal
{
    public abstract void animalSound();
    public void sleep()
    {
        System.Console.WriteLine("zzzz");
    }
    
}

class Program
{
    static void Main(string[] args)
    {
        newanimal yenihayvan = new newanimal();
        yenihayvan.sleep();
    }
}