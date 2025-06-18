namespace StructureExample;

class Point
{
    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }

    public Point(string name, double x, double y)
        : this(x, y)
    {
        Name = name;
    }

    public double X { get; set; }
    public double Y { get; set; }
    public string Name { get; init; }

    public double Add()
    {
        return X + Y;
    }

    public override string ToString()
    {
        return $"Point: {Name}, X: {X}, Y: {Y}";
    }
}
