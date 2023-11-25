using GangOfFour.Creational.ProtoType;

namespace GangOfFour.Test.Creational.ProtoType;

public class TransactionService
{
    public Task CreateAsynce()
    {
        var shareTransaction = new ShareTransaction();
        var shareTransactionClone = shareTransaction.Clone();

        return Task.CompletedTask;
    } 
}
