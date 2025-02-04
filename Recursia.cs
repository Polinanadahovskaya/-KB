public interface IExample
{
    void Method();

    void Log(string message) {
        Console.WriteLine("test1");
    }
    int Property {get; set;}
}

public interface Itest : IExample
{
    void Testik();
}

public class ExampleClass : Itest
{
      public void Method() => Console.WriteLine("test");
    public void Testik() => Console.WriteLine("Testik");
    
    public int Property { get; set;}
}

class Program {
    static void Main() {
        ExampleClass obj = new ExampleClass();
        obj.Method();
        obj.Testik();
    }
}