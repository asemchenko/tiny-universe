using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TimeResouceScript :  MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public void OnPointerEnter(PointerEventData eventData)
    {
        var tooltip = GameObject.Find("ToolTipManager").GetComponent<ResourceTooltip>();
        tooltip.GenerateToolTip("Время","Форма протекания физических и психических процессов, условие возможности изменения.");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        var tooltip = GameObject.Find("ToolTipManager").GetComponent<ResourceTooltip>();
        tooltip.HideToolTip();
    }
}
