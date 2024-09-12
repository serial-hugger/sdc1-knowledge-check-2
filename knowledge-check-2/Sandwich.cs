namespace knowledge_check_2;

public class Sandwich : Food
{
    public int health { get; set; }
    public int tastyness { get; set; }

    override public string ToString()
    {
        return $"name: {name},health: {health},tastyness: {tastyness}";
    }
}