using System.Collections.Generic;

namespace model
{
    public class Star: IResource
    {
        public string GetResourceName()
        {
            return "Звезда";
        }

        public string GetResourceDescription()
        {
            return
                "Массивный газовый шар, излучающий свет и удерживаемый в состоянии равновесия силами собственной гравитации и внутренним давлением, в недрах которого происходят реакции термоядерного синтеза.";
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