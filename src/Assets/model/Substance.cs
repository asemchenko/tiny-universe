namespace model
{
    public class Substance : IResource
    {
        private long _amount;

        public Substance(long amount)
        {
            _amount = amount;
        }

        public string GetResourceName()
        {
            return "Материя";
        }

        public string GetResourceDescription()
        {
            return "Вещество, из которого состоят физические тела";
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
    }
}