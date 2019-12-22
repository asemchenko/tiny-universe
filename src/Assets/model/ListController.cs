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
            // first of all - check that such resource does not exist
            foreach (var resourceDescriptor in _resources)
            {
                if (resourceDescriptor.resource.GetType() == resource.GetType())
                {
                    // updating resource instead of inserting new one
                    resourceDescriptor.resource.IncreaseAmount(resource.GetResourceAmount());
                    resourceDescriptor.controller.resourceAmountText.text =
                        resourceDescriptor.resource.GetResourceAmount().ToString();
                    return;
                }
            }

            insertNewItem(resource);
        }

        public void clear()
        {
            foreach (var resourceDescriptor in _resources)
            {
                Destroy(resourceDescriptor.resourceObject);
            }
            _resources.Clear();
        }

        public bool isEmpty()
        {
            return _resources.Count == 0;
        }

        public List<IResource> getIResources()
        {
            var ireResources = new List<IResource>();
            foreach (var resourceDescriptor in _resources)
            {
                ireResources.Add(resourceDescriptor.resource);
            }

            return ireResources;
        }

        public bool DecrementResource(ResourceDescriptor descriptor)
        {
            var resourceAmount = descriptor.resource.GetResourceAmount();
            if (resourceAmount > 1)
            {
                descriptor.resource.DecreaseAmount(1);
                descriptor.controller.resourceAmountText.text = descriptor.resource.GetResourceAmount().ToString();
                return true;
            }
            if (resourceAmount == 1)
            {
                // deleting resource
                _resources.Remove(descriptor);
                Destroy(descriptor.resourceObject);
                return true;
            }

            return false;
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
            onItemInserted(descriptor);
            // stub for fix unity displaying bug
            controller.resourceAmountText.text = resource.GetResourceAmount().ToString();
            return descriptor;
        }

        /**
         * Is called after new resource item inserted. Normally, this method is used to
         * add onClick event handler for resource in the concrete controllers (ListController child)
         */
        protected virtual void onItemInserted(ResourceDescriptor descriptor)
        {
            
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