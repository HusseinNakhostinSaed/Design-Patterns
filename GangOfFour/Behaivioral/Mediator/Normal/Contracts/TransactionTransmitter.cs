namespace GangOfFour.Behaivioral.Mediator.Normal;

public class TransactionTransmitter : ITransactionTransmitter
{
    private readonly List<TransactionBase> _transactions = new List<TransactionBase>();

    public void AddTransaction(params TransactionBase[] transactions)
    {
        _transactions.AddRange(transactions);
    }

    public void RaiseTransaction(TransactionBase selectedTransactionBase)
    {
        var selectTransactionForNotification = _transactions.Where(x => x == selectedTransactionBase);

        foreach (var transaction in selectTransactionForNotification) { transaction.Notify(); }
    }
}
