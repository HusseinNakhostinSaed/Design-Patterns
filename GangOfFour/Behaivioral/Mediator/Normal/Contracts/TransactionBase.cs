namespace GangOfFour.Behaivioral.Mediator.Normal;

public abstract class TransactionBase
{
    protected readonly ITransactionTransmitter _transactionTransmitter;
    public TransactionBase(ITransactionTransmitter transactionTransmitter)
    {
        _transactionTransmitter = transactionTransmitter;
    }

    public abstract void Raise();
    public abstract void Notify();
}
