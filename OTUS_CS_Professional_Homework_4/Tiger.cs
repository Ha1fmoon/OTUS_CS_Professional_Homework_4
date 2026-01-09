namespace OTUS_CS_Professional_Homework_4;

public class Tiger : Feline, ICloneable
{
    private int PackSize { get; set; }

    public Tiger(string name, int age, double clawLength, int packSize) : base(name, age, clawLength)
    {
        PackSize = packSize;
    }

    private Tiger(Tiger original) : base(original)
    {
        PackSize = original.PackSize;
    }

    public override Animal Clone()
    {
        return new Tiger(this);
    }

    object ICloneable.Clone()
    {
        return new Tiger(this);
    }

    public override string ToString()
    {
        return $"{base.ToString()}, PackSize={PackSize}";
    }
}