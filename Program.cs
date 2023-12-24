

class MyClas
{
    public MyClas()
    {
        
    }

    public int MyProperty { get; set; }

    private static int a;
    private int b;

    public static void Foo()
    {
        Console.WriteLine("Вызван метод Foo");
    }

    public void Bar()
    {
        Console.WriteLine("Вызван метод Bar");
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyClas myClas = new MyClas();

        MyClas.Foo();

        myClas.Bar();
    }
}
