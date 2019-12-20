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
    }
}