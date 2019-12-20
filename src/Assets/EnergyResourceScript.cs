using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EnergyResourceScript : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public void OnPointerEnter(PointerEventData eventData)
    {
        var tooltip = GameObject.Find("ToolTipManager").GetComponent<ResourceTooltip>();
        tooltip.GenerateToolTip("Энергия","Одно из основных свойств материи — мера её движения, а также способность производить работу.");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        var tooltip = GameObject.Find("ToolTipManager").GetComponent<ResourceTooltip>();
        tooltip.HideToolTip();
    }
}
