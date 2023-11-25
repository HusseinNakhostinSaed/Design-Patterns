namespace GangOfFour.Creational.ProtoType;

public class WarrantTransaction : IProtoType
{
    public IProtoType Clone()
    {
        return (IProtoType)this.Clone();
    }
}
