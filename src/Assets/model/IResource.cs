using System.Collections.Generic;
using model;

namespace model
{
    public interface IResource: IEqualityComparer<IResource>
    {
        string GetResourceName();
        string GetResourceDescription();
        long GetResourceAmount();
        bool IsEmpty();
        void IncreaseAmount(long diff);
        void DecreaseAmount(long diff);
        IResource GetOneUnit();
    }
}
class AmountEqualityComparer
{
    public static bool Equals(IResource x, IResource y)
    {
        if (ReferenceEquals(x, y)) return true;
        if (ReferenceEquals(x, null)) return false;
        if (ReferenceEquals(y, null)) return false;
        if (x.GetType() != y.GetType()) return false;
        return x.GetResourceAmount() == y.GetResourceAmount();
    }

    public static int GetHashCode(IResource obj)
    {
        return (int)obj.GetResourceAmount();
    }
}