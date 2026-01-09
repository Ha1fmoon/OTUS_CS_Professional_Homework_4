namespace OTUS_CS_Professional_Homework_4.Class;

public class Wolf : Canine, ICloneable
{
    private int PackSize { get; }

    public Wolf(string name, int age, int loyaltyLevel, int packSize) : base(name, age, loyaltyLevel)
    {
        PackSize = packSize;
    }

    private Wolf(Wolf original) : base(original)
    {
        PackSize = original.PackSize;
    }

    public override Animal Clone()
    {
        return new Wolf(this);
    }

    object ICloneable.Clone()
    {
        return new Wolf(this);
    }

    public override string ToString()
    {
        return $"{base.ToString()}, PackSize={PackSize}";
    }
}