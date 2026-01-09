namespace OTUS_CS_Professional_Homework_4.Class;

public abstract class Canine : Animal
{
    private int LoyaltyLevel { get; }

    protected Canine(string name, int age, int loyaltyLevel) : base(name, age)
    {
        LoyaltyLevel = loyaltyLevel;
    }

    protected Canine(Canine original) : base(original)
    {
        LoyaltyLevel = original.LoyaltyLevel;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, LoyaltyLevel={LoyaltyLevel}";
    }
}