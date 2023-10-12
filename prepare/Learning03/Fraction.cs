public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _bottom = wholeNumber;
    }

    public Fraction(int top, int bottom)
    {   
        _top = top;
        _bottom = bottom;
    }

    public void GetTop()
    {
        Console.WriteLine($"{_top}");
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public void GetBottom()
    {
        Console.WriteLine($"{_bottom}");
    }

    public void SetBottom(int bottom)
    {
        _top = bottom;
    }
    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }




}