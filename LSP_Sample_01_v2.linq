<Query Kind="Program" />

void Main()
{
	Square o = new Square();
	o.Width=40;
	//o.Height=50;
	LSPBehavior.GetArea(o).Dump();
}

public class Square : Rectangle
{
	private int _height;
	private int _width;
	public int Height{get{return _height;}set{_height=_width=value;}}
	public int Width{get{return _width;}set{_width=_height=value;}}
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