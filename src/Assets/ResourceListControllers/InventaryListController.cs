using model;
using UnityEngine;
using UnityEngine.UI;

namespace ResourceListControllers
{
    public class InventaryListController: ListController
    {
        public CraftMenuController CraftMenuController;
        protected override void onItemInserted(ResourceDescriptor descriptor)
        {
            // add onClick on resource handlers
            var button = descriptor.controller.button;
            Debug.Log("Creating onClick listener for an inventary resource: ");
            button.onClick.AddListener((() =>
            {
                CraftMenuController controller = this.CraftMenuController;
                Debug.Log("Processing click for inventary resource via controller: ", controller);
                controller.moveResourceToCraft(descriptor);
            }));
        }
    }
}