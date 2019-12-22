using System.Collections.Generic;

namespace model
{
    public class Space : IResource
    {
        private long _amount;

        public Space(long amount)
        {
            _amount = amount;
        }

        public string GetResourceName()
        {
            return "Пространство";
        }

        public string GetResourceDescription()
        {
            return "Объективная реальность, форма существования материи, характеризующаяся протяжённостью и объёмом.";
        }

        public long GetResourceAmount()
        {
            return _amount;
        }

        public bool IsEmpty()
        {
            return _amount == 0;
        }

        public void IncreaseAmount(long diff)
        {
            _amount += diff;
        }

        public void DecreaseAmount(long diff)
        {
            _amount -= diff;
        }

        public IResource GetOneUnit()
        {
            return new Space(1);
        }


        protected bool Equals(Space other)
        {
            return _amount == other._amount;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Space) obj);
        }

        public override int GetHashCode()
        {
            return _amount.GetHashCode();
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