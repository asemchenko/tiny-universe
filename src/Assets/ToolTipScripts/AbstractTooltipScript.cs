using UnityEngine;
using UnityEngine.EventSystems;

namespace ToolTipScripts
{
    /**
 * This abstract class contains implementation of showing tooltip
 * on any object. To use it you should just create concrete class
 * for necessary UI component, implement all abstract methods of this
 * class and attach created script to necessary UI component
 */
    public abstract class AbstractTooltipScript : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        public void OnPointerEnter(PointerEventData eventData)
        {
            Debug.Log("Triggered onPointerEnter from AbstractToolTipScript");
            var tooltip = GameObject.Find("ToolTipManager").GetComponent<ResourceTooltip>();
            tooltip.GenerateToolTip(getTooltipTitle(),getTooltipDescription());
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            Debug.Log("Triggered onPointerExit from AbstractToolTipScript");
            var tooltip = GameObject.Find("ToolTipManager").GetComponent<ResourceTooltip>();
            tooltip.HideToolTip();
        }

        protected abstract string getTooltipTitle();

        protected abstract string getTooltipDescription();
    }
}
