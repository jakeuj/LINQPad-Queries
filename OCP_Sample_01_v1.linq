<Query Kind="Statements" />

public abstract class DataProvider 
{
	public abstract int OpenConnection();
	public abstract int CloseConnection();
	public abstract int ExcuteCommand();
}