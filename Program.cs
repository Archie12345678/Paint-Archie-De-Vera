using System;
using System.Collections.Generic;
using System.Text;

namespace Paint_Archie_De_Vera
{
    class oop
    {
    }
}
public interface IPaintTool
{
    void MouseOver();
    void MouseUp();
}

public class IPencilTool : IPaintTool
{
    public void MouseOver()
    {
        Console.WriteLine("Show pencil icon");
    }

    public void MouseUp()
    {
        Console.WriteLine("Draw a line.");
    }
}

public class ISquareTool : IPaintTool
{
    public void MouseOver()
    {
        Console.WriteLine("Show square icon");
    }

    public void MouseUp()
    {
        Console.WriteLine("Draw a square.");
    }
}

public class IEraserTool : IPaintTool
{
    public void MouseOver()
    {
        Console.WriteLine("Show an eraser icon");
    }

    public void MouseUp()
    {
        Console.WriteLine("Erase the selected object.");
    }
}