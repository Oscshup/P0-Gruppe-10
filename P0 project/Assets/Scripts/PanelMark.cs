using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;

public class PanelHoverTextMeshPro : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public string hoverText; // The specific text for this panel
    public TextMeshProUGUI displayText; // Reference to the TextMeshPro element


    // Called when the mouse pointer enters the panel
    public void OnPointerEnter(PointerEventData eventData)
    {
        displayText.text = hoverText;
    }

    // Called when the mouse pointer exits the panel
    public void OnPointerExit(PointerEventData eventData)
    {
        displayText.text = "";
    }
}
