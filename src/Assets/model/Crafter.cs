using System.Collections.Generic;
using model;
using UnityEngine;

namespace model
{
    /**
     * Class that performs craft. Is used as craft logic container
     */
    public class Crafter
    {
        private static Dictionary<HashSet<IResource>, IResource> craftMap;

        public Crafter()
        {
            // if craft map has not been initialized
            if (craftMap == null)
            {
                // initializing craft map
                craftMap = new Dictionary<HashSet<IResource>, IResource>(100, new HashSetComparer());
                // space + substance = galaxy
                IResource[] s1 = {new Space(1), new Substance(1)};
                craftMap.Add(new HashSet<IResource>(s1), new Galaxy());
                // time + space = substance
                IResource[] s2 = {new Time(1), new Space(1),};
                craftMap.Add(new HashSet<IResource>(s2), new Substance(1));
                // substance + time = energy
                IResource[] s3 = {new Time(1), new Substance(1),};
                craftMap.Add(new HashSet<IResource>(s2), new Energy(1));
                // substance + energy = H2
                IResource[] s4 = {new Substance(1), new Energy(1),};
                craftMap.Add(new HashSet<IResource>(s4), new Helium(1));
                // Helium + energy = star
                IResource[] s5 = {new Helium(1), new Energy(1),};
                craftMap.Add(new HashSet<IResource>(s5), new Star());
            }
        }

        public bool canBeCrafted(List<IResource> resources)
        {
            Debug.Log("[CRAFTER] Checking if craft is possible for resources: ");
            foreach (var resource in resources)
            {
                Debug.Log("\t" + resource.GetResourceName() + " " + resource.GetResourceAmount().ToString());
            }

            IResource[] arr = {new Time(1), new Space(1)};
            Debug.Log("Check for hashsets equality: " +
                      new HashSet<IResource>(resources).SetEquals(new HashSet<IResource>(arr)).ToString());
            Debug.Log("Check for objects equality: " + new Space(1).Equals(new Space(1)));
            var containsKey = craftMap.ContainsKey(new HashSet<IResource>(resources));
            Debug.Log("Craft is " + containsKey.ToString());
            return containsKey;
        }

        public IResource craft(List<IResource> resources)
        {
            return craftMap[new HashSet<IResource>(resources)];
        }
    }
}

class HashSetComparer : EqualityComparer<HashSet<IResource>>
{
    public override bool Equals(HashSet<IResource> x, HashSet<IResource> y)
    {
        if (x == null && x != y)
        {
            return false;
        }

        return x.SetEquals(y);
    }

    public override int GetHashCode(HashSet<IResource> obj)
    {
        int hash = 13;
        foreach (var resource in obj)
        {
            hash = hash * 13 + resource.GetHashCode();
        }

        return hash;
    }
}