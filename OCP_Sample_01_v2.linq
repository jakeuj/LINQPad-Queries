<Query Kind="Program" />

void Main()
{
	DataProvider DataProviderObject = new MySqlDataProvider();
	DataProviderObject.OpenConnection();
	DataProviderObject.ExcuteCommand();
	DataProviderObject.CloseConnection();
	
	DataProviderObject = new OracleDataProvider();
	DataProviderObject.OpenConnection();
	DataProviderObject.ExcuteCommand();
	DataProviderObject.CloseConnection();
}

public abstract class DataProvider 
{
	public abstract int OpenConnection();
	public abstract int CloseConnection();
	public abstract int ExcuteCommand();
}

class MySqlDataProvider:DataProvider
{
	public override int OpenConnection(){return 1;}
	public override int CloseConnection(){return 1;}
	public override int ExcuteCommand(){return 1;}
}

class OracleDataProvider:DataProvider
{
	public override int OpenConnection(){return 1;}
	public override int CloseConnection(){return 1;}
	public override int ExcuteCommand(){return 1;}
}