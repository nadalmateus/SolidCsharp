public class Person
{
    public string Name;
    public int Age;

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void Identify()
    {
        System.Console.WriteLine($"My name is {Name} and i'm {Age} years old");
    }
}