namespace GangOfFour.Creational.AbstractFactory;

public class TransactionService : ITransactionService
{
    public IWarrantTransaction WarrantTransaction
    {
        get
        {
            return new WarrantTransaction();
        }
    }

    public IShareTransaction ShareTransaction
    {
        get
        {
            return new ShareTransaction();
        }
    }

    public ICapitalChangeTransaction CapitalChangeTransaction
    {
        get
        {
            return new CapitalChangeTransaction();
        }
    }
}
