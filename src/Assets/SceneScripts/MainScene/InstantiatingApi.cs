using System;
using UnityEngine;

namespace MainScene
{
    /**
     * API for creating & positioning new object on the scene
     */
    public class InstantiatingApi : MonoBehaviour
    {
        public GameObject galaxyPrefab;

        public void CreateGalaxy()
        {
            instantiatePrefab(galaxyPrefab);
        }

        public void CreateStar()
        {
            throw new NotImplementedException();
        }

        public void CreatePlanet()
        {
            throw new NotImplementedException();
        }

        private void instantiatePrefab(GameObject prefab)
        {
            var result = Instantiate(prefab, new Vector3(5, 0, 0), Quaternion.identity);
            result.GetComponent<SpriteRenderer>().sortingOrder = 2;
        }
    }
}