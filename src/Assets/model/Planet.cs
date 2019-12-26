using System;
using System.Collections.Generic;

namespace model
{
    public class Planet : SolidEntity
    {
        public static Planet createPlanet(List<IResource> source)
        {
            var planet = new Planet();
            planet.content = source;
            // 180 - 480 seconds
            planet.remainLifeTime = new Random().Next(180, 480);
            return planet;
        }

        public override string GetResourceName()
        {
            return "Планета";
        }

        public override string GetResourceDescription()
        {
            return "Небесное тело, вращающееся вокруг звезды и получающее от него свет и тепло.";
        }

        public override long GetResourceAmount()
        {
            return 1;
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

        public override int GetHashCode(IResource obj)
        {
            return 1;
        }
    }
}