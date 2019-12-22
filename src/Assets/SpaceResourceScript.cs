using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SpaceResourceScript :  MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public void OnPointerEnter(PointerEventData eventData)
    {
        var tooltip = GameObject.Find("ToolTipManager").GetComponent<ResourceTooltip>();
        tooltip.GenerateToolTip("Пространство","Объективная реальность, форма существования материи, характеризующаяся протяжённостью и объёмом.");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        var tooltip = GameObject.Find("ToolTipManager").GetComponent<ResourceTooltip>();
        tooltip.HideToolTip();
    }
}
