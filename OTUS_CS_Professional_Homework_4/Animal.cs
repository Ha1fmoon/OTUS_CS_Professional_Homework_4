namespace OTUS_CS_Professional_Homework_4;

public abstract class Animal : IMyCloneable<Animal>
{
    public string Name { get; set; }
    public int Age { get; set; }

    protected Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    protected Animal(Animal original)
    {
        Name = original.Name;
        Age = original.Age;
    }

    public abstract Animal Clone();

    public override string ToString()
    {
        return $"{GetType().Name}: Name={Name}, Age={Age}";
    }
}