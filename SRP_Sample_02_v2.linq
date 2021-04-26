<Query Kind="Statements" />

public class OrderManger
{
	public void Processing()
	{
		new Stock().CheckAvailability();
		new Payment().Processing();
		new Shipment().SendProduct();
	}
}
public class Stock
{
	public void CheckAvailability(){}
}
public class Payment
{
	public void Processing(){}
}
public class Shipment
{
	public void SendProduct(){}
}