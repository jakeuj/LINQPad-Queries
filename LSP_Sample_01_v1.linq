<Query Kind="Program" />

void Main()
{
	Rectangle o = new Rectangle();
	o.Width=40;
	o.Height=50;
	LSPBehavior.GetArea(o).Dump();
}

public class Rectangle
{
	public int Height{get;set;}
	public int Width{get;set;}
}

public class LSPBehavior
{
	public static int GetArea(Rectangle s)
	{
		if(s.Height>20)
		{
			s.Width=20;
		}
		return s.Width*s.Height;
	}
}