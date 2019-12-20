using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace model
{
    public abstract class ListController : MonoBehaviour
    {
        public List<ResourceDescriptor> _resources =  new List<ResourceDescriptor>();
        public GameObject listContentPanel;
        public GameObject ListItemPrefab;

        public List<ResourceDescriptor> getResources()
        {
            return _resources;
        }

        public void appendResource(IResource resource)
        {
            insertNewItem(resource);
        }

        protected ResourceDescriptor insertNewItem(IResource resource)
        {
            Debug.Log("Inserting resource " + resource.GetResourceName() + " with amount: " + resource.GetResourceAmount().ToString());
            // instantiating element
            var newResource = Instantiate(ListItemPrefab);
            var controller = newResource.GetComponent<ListItemController>();
            Debug.Log("Successfully instantiated resource");
            // setting values for new element
            // TODO set image here
//            controller.Image = smth
            controller.resourceNameText.text = resource.GetResourceName();
            controller.resourceAmountText.text = resource.GetResourceAmount().ToString();
            newResource.transform.parent = listContentPanel.transform;
            newResource.transform.localScale = Vector3.one;
            Debug.Log("Created resource successfully moved to listContent: " + listContentPanel);
            // inserting created objects to the internal list
            var descriptor = new ResourceDescriptor(newResource, controller, resource);
            _resources.Add(descriptor);
            return descriptor;
        }

        public class ResourceDescriptor
        {
            public ListItemController controller;
            public IResource resource;
            public GameObject resourceObject;

            public ResourceDescriptor(GameObject resourceObject, ListItemController controller, IResource resource)
            {
                this.resourceObject = resourceObject;
                this.controller = controller;
                this.resource = resource;
            }
        }
    }
}