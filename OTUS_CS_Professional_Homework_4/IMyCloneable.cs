namespace OTUS_CS_Professional_Homework_4;

public interface IMyCloneable<out T> where T : class
{
    T Clone();
}