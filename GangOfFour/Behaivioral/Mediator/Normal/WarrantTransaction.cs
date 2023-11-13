namespace GangOfFour.Behaivioral.Mediator.Normal;

public class WarrantTransaction : TransactionBase
{
    public WarrantTransaction(ITransactionTransmitter transactionTransmitter) : base(transactionTransmitter)
    {
    }

    public override void Raise()
    {
        //Do some work
        _transactionTransmitter.RaiseTransaction(this);
    }

    public override void Notify()
    {
        //Do some work
        Console.WriteLine("Successfully received");
    }
}
