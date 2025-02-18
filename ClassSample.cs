// Base class

public class Animal
{
    public string Name { get; set;}
    public int Age { get; set;}
}

// child class
public class dog : Animal
{
    public void HowOld()
    {
         Console.WriteLine("나이 :{0}", this.Age);
    }
}

public class Bird : Animal
{
    public void Fly()
    {
        Console.WriteLine("{0} is flying", this.Name);
    }
}