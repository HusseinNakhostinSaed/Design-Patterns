namespace GangOfFour.Creational;

public interface ITransactionService
{
    IWarrantTransaction WarrantTransaction { get; }
    IShareTransaction ShareTransaction { get; }
    ICapitalChangeTransaction CapitalChangeTransaction { get; }
}
