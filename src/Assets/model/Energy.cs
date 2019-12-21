namespace model
{
    public class Energy : IResource
    {
        private long _amount;

        public Energy(long amount)
        {
            _amount = amount;
        }

        public string GetResourceName()
        {
            return "Энергия";
        }

        public string GetResourceDescription()
        {
            return "Одно из основных свойств материи — мера её движения, а также способность производить работу";
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
            return new Energy(1);
        }

        protected bool Equals(Energy other)
        {
            return _amount == other._amount;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Energy) obj);
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