using model;
using UnityEngine;

namespace ResourceListControllers
{
    public class CraftResultListController: ListController
    {
        public CraftMenuController CraftMenuController;
        protected override void onItemInserted(ResourceDescriptor descriptor)
        {
            // add onClick on resource handlers
            var button = descriptor.controller.button;
            Debug.Log("Creating onClick listener for an craft result resource: ");
            var type = descriptor.resource.GetType();
            if (type.Equals(typeof(Star)) || type.Equals(typeof(Galaxy)))
            {
                    // TODO insert Luda's code here    
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