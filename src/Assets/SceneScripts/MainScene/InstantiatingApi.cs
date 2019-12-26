using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace MainScene
{
    /**
     * API for creating & positioning new object on the scene
     */
    public class InstantiatingApi : MonoBehaviour
    {
        public GameObject galaxyPrefab;
        public GameObject starPrefab;
        public GameObject mainCanvas;

        public void Start()
        {
            placeAllUnplacedObjects();
        }

        public void CreateGalaxy()
        {
            instantiatePrefab(galaxyPrefab);
        }

        public void CreateStar()
        {
            Debug.Log("Instantiating star ...");
            var result = Instantiate(starPrefab, new Vector3(0, 100, 0), Quaternion.identity);
            result.GetComponent<SpriteRenderer>().sortingOrder = 1;
            result.transform.parent = mainCanvas.transform;
            result.AddComponent<ObjectPlacementScript>();
            ObjectPlacementScript.markStarUnplaced();
        }

        public void CreatePlanet()
        {
            throw new NotImplementedException();
        }

        private GameObject instantiatePrefab(GameObject prefab)
        {
            var result = Instantiate(prefab, new Vector3(5, 0, 0), Quaternion.identity);
            result.GetComponent<SpriteRenderer>().sortingOrder = 2;
            return result;
        }

        private void placeAllUnplacedObjects()
        {
            Debug.Log("Start instantiating all unplaced objects.");
            if (ObjectPlacementScript.isPresentUnplacedObject)
            {
                Debug.Log("Instantiating unplaced objects");
                if (ObjectPlacementScript.unplacedObject == SpriteType.STAR)
                {
                    CreateStar();
                }   
            }
        }
    }
}