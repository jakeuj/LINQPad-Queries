<Query Kind="Program" />

void Main()
{
	List<FlyBird> Birds = new List<FlyBird>();
	// Add Bird Logic
	Birds.Add(new Eagle());
	foreach(var bird in Birds)
	{
	     bird.Fly();      
	}
}
interface IMove
{
	void Move();
}
interface IFly
{
	void Fly();
}

class BirdBase:IMove
{
	public virtual void Move()
　　{
　　　　// Move Logic
　　} 
}

class FlyBird:BirdBase,IFly
{
  	public virtual void Fly()
　　{
　　　　// Fly Logic
		"I can fly".Dump();
　　}  
}

class Eagle: FlyBird
{
}

class Penguin: BirdBase
{
}