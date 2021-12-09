using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

[RequireComponent (typeof(Outline))]
public class OutlineGrabbable : XRGrabInteractable
{
    private Outline outline;
    private WarningLights warningLights;


    private void Awake()
    {
        base.Awake();

        warningLights = FindObjectOfType<WarningLights>();

        outline = GetComponent<Outline>();

        hoverEntered.AddListener(outline.DoOutline);
        hoverExited.AddListener(outline.RemoveOutline);

        selectEntered.AddListener(warningLights.TurnOnWarningLights);
        selectExited.AddListener(warningLights.TurnOffWarningLights);
        
    }


}
