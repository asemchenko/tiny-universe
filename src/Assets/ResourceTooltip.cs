using UnityEngine;
using UnityEngine.UI;

public class ResourceTooltip : MonoBehaviour
{
    public Text tooltipText;
    public Image tooltipImage;
    public Text tooltipTitle;

    // Start is called before the first frame update
    private void Start()
    {
        Debug.Log("Initializing tooltip");
        tooltipImage.gameObject.SetActive(false);
        HideToolTip();
    }

    public void GenerateToolTip(string title ,string text)
    {
        tooltipImage.gameObject.SetActive(true);
        tooltipText.text = text;
        tooltipTitle.text = title;
    }

    public void HideToolTip()
    {
        tooltipImage.gameObject.SetActive(false);
    }
}