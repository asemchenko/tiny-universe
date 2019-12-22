using model;
using UnityEngine;

namespace ResourceListControllers
{
    public class CraftResultListController: ListController
    {
        public CraftMenuController CraftMenuController;
        public PauseMenuManager PauseMenuManager;
        public GameObject prefab;
        protected override void onItemInserted(ResourceDescriptor descriptor)
        {
            // add onClick on resource handlers
            var button = descriptor.controller.button;
            Debug.Log("Creating onClick listener for an craft result resource: ");
            var type = descriptor.resource.GetType();
            if (type.Equals(typeof(Star)) || type.Equals(typeof(Galaxy)))
            {
                button.onClick.AddListener((() =>
                {
                    PauseMenuManager.CloseCraftMenu();
                    GameObject result = Instantiate(prefab, new Vector3(5, 0, 0), Quaternion.identity) as GameObject;
                    result.GetComponent<SpriteRenderer>().sortingOrder = 2;
                    clear();
                }));
            } else if (type.Equals(typeof(Star)))
            {
                PauseMenuManager.CloseCraftMenu();
                // TODO Luda instantiate star here and call API method to put it
                clear();
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