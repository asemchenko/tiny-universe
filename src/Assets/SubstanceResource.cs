using UnityEngine;
using UnityEngine.EventSystems;

public class SubstanceResource : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public void OnPointerEnter(PointerEventData eventData)
    {
        var tooltip = GameObject.Find("ToolTipManager").GetComponent<ResourceTooltip>();
        tooltip.GenerateToolTip("Материя", "Вещество, из которого состоят физические тела.");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        var tooltip = GameObject.Find("ToolTipManager").GetComponent<ResourceTooltip>();
        tooltip.HideToolTip();
    }
}