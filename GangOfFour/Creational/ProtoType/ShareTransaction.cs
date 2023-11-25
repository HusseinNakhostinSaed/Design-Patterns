namespace GangOfFour.Creational.ProtoType;

public class ShareTransaction : IProtoType
{
    public IProtoType Clone()
    {
        //return a shallow copy of the proto type
        return (IProtoType)this.MemberwiseClone();
    }
}
