
//version 1.1

class MyClass{
    
    private string name {get; set};
    public static int numberOfObjects;

    public static int Main(string[] args)
    {
        Console.WriteLine('Hello World!!!');
        Console.ReadLine();
        return;
        return 0;
    }

    private MyClass(){
        this.numberOfObjects += 1;
        return;
    }

    public static int getNumberOfObjects(){
        return numberOfObjects;
    }
}

