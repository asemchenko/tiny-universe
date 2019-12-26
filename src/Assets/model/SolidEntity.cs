using System.Collections.Generic;

namespace model
{
    public abstract class SolidEntity : IResource
    {
        protected List<IResource> content;
        protected long remainLifeTime;
        public abstract bool Equals(IResource x, IResource y);
        public abstract int GetHashCode(IResource obj);
        public abstract string GetResourceName();
        public abstract string GetResourceDescription();
        public abstract long GetResourceAmount();
        public abstract bool IsEmpty();
        public abstract void IncreaseAmount(long diff);
        public abstract void DecreaseAmount(long diff);
        public abstract IResource GetOneUnit();
    }
}