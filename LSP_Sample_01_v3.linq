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
	public override int Height{get{return _height;}set{_height=_width=value;}}
	public override int Width{get{return _width;}set{_width=_height=value;}}
}

public class Rectangle
{
	public virtual int Height{get;set;}
	public virtual int Width{get;set;}
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