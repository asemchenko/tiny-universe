using System.Collections;
using System.Collections.Generic;
using model;
using ToolTipScripts;
using UnityEngine;

public class GalaxyTooltipScript : AbstractTooltipScript
{
    private Galaxy stub = new Galaxy();
    protected override string getTooltipTitle()
    {
        return stub.GetResourceName();
    }

    protected override string getTooltipDescription()
    {
        return stub.GetResourceDescription();
    }
}
