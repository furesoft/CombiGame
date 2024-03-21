namespace CombiGame.Models;

public record Item(string Name)
{
    public static CombinationItem operator +(Item first, Item second)
    {
        return new(first, second);
    }

    public override string ToString()
    {
        return Name;
    }
}