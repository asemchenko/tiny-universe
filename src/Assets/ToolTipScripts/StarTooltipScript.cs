using System.Collections;
using System.Collections.Generic;
using model;
using ToolTipScripts;
using UnityEngine;

public class StarTooltipScript : AbstractTooltipScript
{
    protected override string getTooltipTitle()
    {
        return new Star().GetResourceName();
    }

    protected override string getTooltipDescription()
    {
        return new Star().GetResourceDescription();
    }
}
