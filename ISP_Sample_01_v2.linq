<Query Kind="Program" />

void Main()
{
	IDataProviderWithoutTransaction DataProviderObject = new SqlDataProvider();
	DataProviderObject.OpenConnection();
	DataProviderObject.CloseConnection();
	DataProviderObject.ExcuteCommand();
}

interface IDataProviderWithoutTransaction
{
	int OpenConnection();
	int CloseConnection();
	int ExcuteCommand();
}

interface IDataProvider:IDataProviderWithoutTransaction
{
	int BeginTransaction();
}

class SqlDataProvider:IDataProvider
{
	public int OpenConnection(){throw new NotImplementedException();}
	public int CloseConnection(){throw new NotImplementedException();}
	public int ExcuteCommand(){throw new NotImplementedException();}
	public int BeginTransaction(){throw new NotImplementedException();}
}