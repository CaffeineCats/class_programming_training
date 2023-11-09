using System.Reflection.Metadata.Ecma335;

public class Shape
{
    private string _color;

    protected Shape(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }
    protected void SetColor(string color)
    {
        _color = color;
    }

    public virtual float GetArea()
    {
        return 5320;
    }

}