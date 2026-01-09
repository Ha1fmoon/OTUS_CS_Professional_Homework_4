namespace OTUS_CS_Professional_Homework_4.Class;

public class Dog : Canine, ICloneable
{
    private string Breed { get; }

    public Dog(string name, int age, int loyaltyLevel, string breed) : base(name, age, loyaltyLevel)
    {
        Breed = breed;
    }

    private Dog(Dog original) : base(original)
    {
        Breed = original.Breed;
    }

    public override Animal Clone()
    {
        return new Dog(this);
    }

    object ICloneable.Clone()
    {
        return new Dog(this);
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Breed={Breed}";
    }
}