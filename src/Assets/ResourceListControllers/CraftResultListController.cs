using MainScene;
using model;
using UnityEngine;

namespace ResourceListControllers
{
    public class CraftResultListController: ListController
    {
        public CraftMenuController CraftMenuController;
        public PauseMenuManager PauseMenuManager;
        public GameObject prefab;
        public InstantiatingApi InstantiatingApi;
        protected override void onItemInserted(ResourceDescriptor descriptor)
        {
            // add onClick on resource handlers
            var button = descriptor.controller.button;
            Debug.Log("Creating onClick listener for an craft result resource: ");
            var type = descriptor.resource.GetType();
            if (type ==(typeof(Galaxy)))
            {
                button.onClick.AddListener((() =>
                {
                    // FIXME asem [REFACTOR] replace this code with calling api-method from InstantiatingApi script
                    PauseMenuManager.CloseCraftMenu();
                    var result = Instantiate(prefab, new Vector3(5, 0, 0), Quaternion.identity) as GameObject;
                    result.GetComponent<SpriteRenderer>().sortingOrder = 2;
                    clear();
                }));
            } else if (type == (typeof(Star)))
            {
                button.onClick.AddListener((() =>
                {
                    PauseMenuManager.CloseCraftMenu();
                    InstantiatingApi.CreateStar();
                    clear();
                }));
            } else if (type == (typeof(Planet)))
            {
                button.onClick.AddListener((() =>
                {
                    PauseMenuManager.CloseCraftMenu();
                    InstantiatingApi.CreatePlanet();
                    clear();
                }));
            }
            else
            {
                button.onClick.AddListener((() =>
                {
                    CraftMenuController controller = this.CraftMenuController;
                    Debug.Log("Processing click for craft resource via controller: ", controller);
                    controller.moveCraftResultToResources(descriptor);
                }));
            }
        }
    }
}