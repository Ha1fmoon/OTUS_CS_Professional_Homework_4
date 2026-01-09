namespace OTUS_CS_Professional_Homework_4.Class;

public abstract class Feline : Animal
{
    private double ClawLength { get; }

    protected Feline(string name, int age, double clawLength) : base(name, age)
    {
        ClawLength = clawLength;
    }

    protected Feline(Feline original) : base(original)
    {
        ClawLength = original.ClawLength;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, ClawLength={ClawLength}cm";
    }
}