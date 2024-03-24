// Shapes 
// Point - (X/y)

using System.Drawing;
using Microsoft.VisualBasic;
stroke myStroke = new stroke(ConsoleColor.Red, ConsoleColor.Black, ' ');
Console.Clear();
Console.CursorVisible = true;
var Point = new Point(1,3, myStroke);

Point.Draw();


public abstract class Shaper()
{
    public ConsoleColor ForeGroundColor { get; set; }
    public ConsoleColor Background {get; set;}
    public char Shape {get; set;}


    public abstract void Draw();
}

public class Point(int x, int y, stroke stroke) : Shaper()
{
    
    public override void Draw()
    {
       Console.SetCursorPosition(x,y);
       Console.ForegroundColor = stroke.Fgc;
       Console.BackgroundColor = stroke.Bgc;
       Console.WriteLine(stroke.Shape);
    }
}
public record struct stroke(ConsoleColor Fgc,ConsoleColor Bgc, char Shape);