namespace OTUS_CS_Professional_Homework_4;

public class Cat : Feline, ICloneable
{
    public string Breed { get; set; }

    public Cat(string name, int age, double clawLength, string breed) : base(name, age, clawLength)
    {
        Breed = breed;
    }

    private Cat(Cat original) : base(original)
    {
        Breed = original.Breed;
    }

    public override Animal Clone()
    {
        return new Cat(this);
    }

    object ICloneable.Clone()
    {
        return new Cat(this);
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Breed={Breed}";
    }
}