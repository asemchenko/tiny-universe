using System.Collections.Generic;

namespace model
{
    public class Time : IResource
    {
        public Time(long amount)
        {
            _amount = amount;
        }

        private long _amount;

        public string GetResourceName()
        {
            return "Время"; // TODO make special constant for messages instead of hardcode
        }

        public string GetResourceDescription()
        {
            return "Форма протекания физических и психических процессов, условие возможности изменения";
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

        public long GetResourceAmount()
        {
            return _amount;
        }

        public IResource GetOneUnit()
        {
            return new Time(1);
        }

        protected bool Equals(Time other)
        {
            return _amount == other._amount;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Time) obj);
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