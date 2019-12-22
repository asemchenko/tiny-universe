using System.Collections;
using System.Collections.Generic;
using model;
using UnityEngine;
using UnityEngine.UI;

public class ListItemController : MonoBehaviour
{
    public Image Image;
    public Text resourceNameText;
    public Text resourceAmountText;
    public Button button;
    public ListController.ResourceDescriptor descriptor;
}
