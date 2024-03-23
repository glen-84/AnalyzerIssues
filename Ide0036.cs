namespace X;

sealed public class Ide0036 // should error (should be `public sealed`)
{
    readonly private int x; // should error (should be `private readonly`)

    public Ide0036()
    {
        this.x = 0; // this works "Name can be simplified (IDE0003)"

        Console.WriteLine(x);
    }
}
