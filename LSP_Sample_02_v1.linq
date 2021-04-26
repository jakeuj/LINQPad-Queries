<Query Kind="Program" />

void Main()
{
	List<Bird> Birds = new List<Bird>();
	// Add Bird Logic
	Birds.Add(new Eagle());
	Birds.Add(new Penguin());
	foreach(var bird in Birds)
	{
	     bird.Fly();      
	}
}

class Bird
{
	public virtual void Move()
　　{
　　　　// Move Logic
　　} 
  	public virtual void Fly()
　　{
　　　　// Fly Logic
		"I can fly".Dump();
　　}
}

class Eagle: Bird
{
}

class Penguin: Bird
{
    public override void Fly()
    {
        throw new Exception("Can Not Fly");
    }
}