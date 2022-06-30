interface Ianimal
{
    void sound();
    void names();
}
interface Iname
{
    void kopek();
    
}
interface emre
{
    void yakisikli();
}
class hayvan : Ianimal,Iname
{
    public void sound()
    {
        System.Console.WriteLine("Hayvan sesleri denemesi");
    }
    public void names()
    {
        System.Console.WriteLine("Ördek köpek kuş");
    }
    public void kopek(){
        System.Console.WriteLine("Haw Haw");
    }
    public void yakisikli()
    {
        System.Console.WriteLine("Çok Yakışıklı");
    }
}

class Program
{
    static void Main(string[] args)
    {
        hayvan hayvan1 = new hayvan();
        hayvan1.kopek();
        hayvan1.sound();
        hayvan1.yakisikli();
        
    }
}

