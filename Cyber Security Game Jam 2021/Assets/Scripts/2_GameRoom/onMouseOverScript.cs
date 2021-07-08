using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class onMouseOverScript : MonoBehaviour
{
    [SerializeField]
    private GameObject hoverCanvas;
    public void OnMouseOver()
    {
        //If your mouse hovers over the GameObject with the script attached, output this message
        hoverCanvas.SetActive(true);
    }

    public void OnMouseExit()
    {
        //The mouse is no longer hovering over the GameObject so output this message each frame
        hoverCanvas.SetActive(false);
        
    }
}