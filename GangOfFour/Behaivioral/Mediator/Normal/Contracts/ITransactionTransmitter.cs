namespace GangOfFour.Behaivioral.Mediator.Normal;

public interface ITransactionTransmitter
{
    void AddTransaction(params TransactionBase[] transactions);
    void RaiseTransaction(TransactionBase selectedTransactionBase);
}
