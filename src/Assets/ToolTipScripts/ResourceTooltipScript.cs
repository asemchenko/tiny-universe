namespace ToolTipScripts
{
    public class ResourceTooltipScript: AbstractTooltipScript
    {
        public ListItemController controller;
        protected override string getTooltipTitle()
        {
            return controller.descriptor.resource.GetResourceName();
        }

        protected override string getTooltipDescription()
        {
            return controller.descriptor.resource.GetResourceDescription();
        }
    }
}