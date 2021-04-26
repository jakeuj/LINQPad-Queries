<Query Kind="Program" />

void Main()
{
	IDataProvider DataProviderObject = new SqlDataProvider();
	DataProviderObject.OpenConnection();
	DataProviderObject.CloseConnection();
	DataProviderObject.ExcuteCommand();
}

interface IDataProvider
{
	int OpenConnection();
	int CloseConnection();
	int ExcuteCommand();
	int BeginTransaction();
}

class SqlDataProvider:IDataProvider
{
	public int OpenConnection(){throw new NotImplementedException();}
	public int CloseConnection(){throw new NotImplementedException();}
	public int ExcuteCommand(){throw new NotImplementedException();}
	public int BeginTransaction(){throw new NotImplementedException();}
}