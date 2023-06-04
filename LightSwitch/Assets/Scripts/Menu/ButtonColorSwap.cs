using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class ButtonColorSwap : MonoBehaviour
{
     private Color normalColor;   // The normal color of the button
    private Color hoverColor = Color.white;  // The color to change to when hovered

    private Image buttonImage;
    // Start is called before the first frame update

 private void Start()
    {
        // Get the Image component attached to the button
        buttonImage = GetComponent<Image>();
        // Store the normal color of the button
        normalColor = buttonImage.color;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        // Change the button color to the hover color
        buttonImage.color = hoverColor;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        // Change the button color back to the normal color
        buttonImage.color = normalColor;
    }
}
