namespace X;

public interface IExample
{
    public int Example { get; set; } // should error (should not have `public` modifier)
}
