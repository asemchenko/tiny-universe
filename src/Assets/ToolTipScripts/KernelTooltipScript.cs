using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ToolTipScripts
{
    public class KernelTooltipScript : AbstractTooltipScript
    {
        protected override string getTooltipTitle()
        {
            return "Ядро мироздания";
        }

        protected override string getTooltipDescription()
        {
            return "Основа всего сущего, бессменный поставщик и потребитель ресурсов";
        }
    }

}
