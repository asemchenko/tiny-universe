using System.Collections.Generic;

namespace model
{
    public class Galaxy: IResource
    {
        public string GetResourceName()
        {
            return "Галактика";
        }

        public string GetResourceDescription()
        {
            return
                "Гравитационно-связанная система из звёзд, звёздных скоплений, межзвёздного газа и пыли, тёмной материи, планет";
        }

        public long GetResourceAmount()
        {
            return 1L;
        }

        public bool IsEmpty()
        {
            return false;
        }

        public void IncreaseAmount(long diff)
        {
            throw new System.NotImplementedException();
        }

        public void DecreaseAmount(long diff)
        {
            throw new System.NotImplementedException();
        }

        public IResource GetOneUnit()
        {
            return this;
        }

        protected bool Equals(Galaxy other)
        {
            return true;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Galaxy) obj);
        }

        public override int GetHashCode()
        {
            return 1;
        }
        public bool Equals(IResource x, IResource y)
        {
            return AmountEqualityComparer.Equals(x, y);
        }

        public int GetHashCode(IResource obj)
        {
            return AmountEqualityComparer.GetHashCode(obj);
        }
    }
}