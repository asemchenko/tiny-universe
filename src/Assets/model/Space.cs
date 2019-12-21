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
    }
}