public class Geometri
{
    public virtual double Area()
    {
        return 0.0;
    }
}

public class Rektangel : Geometri//Denna och alla andra klasser ärver från Geometri
{
    public double Length { get; set; }
    public double Width { get; set; }

    public Rektangel()
    {
        Length = 5;
        Width = 4;
    }

    public override double Area()//här overridar vi metoden och bestämmer vad som ska returneras
    {
        return Length * Width;
    }
}

public class Fyrkant : Geometri
{
    public double SideLength { get; set; }

    public Fyrkant()
    {
        SideLength = 6;
    }

    public override double Area()
    {
        return SideLength * SideLength;
    }
}

public class Cirkel : Geometri
{
    public double Radius { get; set; }

    public Cirkel()
    {
        Radius = 3;
    }

    public override double Area()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}

public class Parallellogram : Geometri
{
    public double BaseLength { get; set; }
    public double Height { get; set; }

    public Parallellogram()
    {
        BaseLength = 7;
        Height = 8;
    }

    public override double Area()
    {
        return BaseLength * Height;
    }
}

public class Ellips : Geometri
{
    public double MajorAxis { get; set; }
    public double MinorAxis { get; set; }

    public Ellips()
    {
        MajorAxis = 5;
        MinorAxis = 3;
    }

    public override double Area()
    {
        return Math.PI * MajorAxis * MinorAxis;
    }
}
