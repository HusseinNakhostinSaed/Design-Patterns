namespace GangOfFour.Test.Creational.Abstract_Factory;

public class TradeService
{
    private readonly ITransactionService _transactionService;
    public TradeService(ITransactionService transactionService)
    {
        _transactionService = transactionService;
    }

    public void Trade()
    {
        _transactionService.WarrantTransaction.Apply();
    }
}
