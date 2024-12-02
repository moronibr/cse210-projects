using System;

public class Square : Shape
{
    private Double _side;

    public Square(string color, double side) : base(color)
    {
        _side = side;
       
    }

    public override double GetArea()
    {
        return _side * _side;
    }
}
