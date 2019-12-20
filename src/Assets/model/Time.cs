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
    }
}