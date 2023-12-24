

class MyClas
{
    public MyClas()
    {
        
    }

    public static int MyProperty { get; set; }

    private static int a;

    public static int A
    {
        get { return a; }
        set { a = value; }
    }

    private int b;

    public static void Foo()
    {
        Console.WriteLine("Вызван метод Foo");

        //a = 11;
        //Console.WriteLine(a);
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

        MyClas.A = 25;

        MyClas.MyProperty = 55;


        Static_Method.Counter counter = new Static_Method.Counter();
        Static_Method.Counter counter2= new Static_Method.Counter();
        Static_Method.Counter counter3= new Static_Method.Counter();
        Console.WriteLine(Static_Method.Counter.CounterProperty);
        
    }
}
