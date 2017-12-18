using System.Collections.Generic;

public class Rectangle
{
    public double Sides { get; } = 4;
    public double Height { get; set; }
    public double Width { get; set; }

    public class AreaOperations
{
    public static double Sum(IEnumerable<Rectangle> rectangles)
    {
        double area= 0;
        foreach (var rectangle in rectangles)
        area += rectangle.Height * rectangle.Width;

        return area;
        
    }
}

public class PerimeterOperations
{
    public static double Sum(IEnumerable<Rectangle> rectangles)
    {
        double perimeter= 0;
        foreach (var rectangle in rectangles)
            perimeter += 2* rectangle.Height + 2 * rectangle.Width;
        return perimeter;
    
    }
}

}
