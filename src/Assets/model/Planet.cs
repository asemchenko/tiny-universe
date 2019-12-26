using System.Collections.Generic;

namespace model
{
    public class Planet: IResource
    {
        public string GetResourceName()
        {
            return "Планета";
        }

        public string GetResourceDescription()
        {
            return "Небесное тело, вращающееся вокруг звезды и получающее от него свет и тепло.";
        }

        public long GetResourceAmount()
        {
            return 1;
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

        public bool Equals(IResource x, IResource y)
        {
            if (x == null && y == null)
            {
                return true;
            }

            if (x != null && y != null)
            {
                return x.GetType() == y.GetType();
            }

            return false;
        }

        public int GetHashCode(IResource obj)
        {
            return 1;
        }
    }
}