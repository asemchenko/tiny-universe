using System;
using System.Collections.Generic;

namespace model
{
    public class Star: SolidEntity
    {
        public static Star createStar(List<IResource> source)
        {
            var star = new Star();
            star.content = source;
            // 300 - 600 seconds
            star.remainLifeTime = new Random().Next(300, 600);
            return star;
        }
        public override string GetResourceName()
        {
            return "Звезда";
        }

        public override string GetResourceDescription()
        {
            return
                "Массивный газовый шар, излучающий свет и удерживаемый в состоянии равновесия силами собственной гравитации и внутренним давлением, в недрах которого происходят реакции термоядерного синтеза.";
        }

        public override long GetResourceAmount()
        {
            return 1L;
        }

        public override bool IsEmpty()
        {
            return false;
        }

        public override void IncreaseAmount(long diff)
        {
            throw new System.NotImplementedException();
        }

        public override void DecreaseAmount(long diff)
        {
            throw new System.NotImplementedException();
        }

        public override IResource GetOneUnit()
        {
            return this;
        }

        public override bool Equals(IResource x, IResource y)
        {
            return AmountEqualityComparer.Equals(x, y);
        }

        public override int GetHashCode(IResource obj)
        {
            return AmountEqualityComparer.GetHashCode(obj);
        }
    }
}