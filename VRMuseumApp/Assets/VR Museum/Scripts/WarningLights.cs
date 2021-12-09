using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;

public class WarningLights : MonoBehaviour
{
    private Animator lightsAnimator;

    private void Awake()
    {
        lightsAnimator = GetComponent<Animator>();
    }


    public void TurnOnWarningLights(SelectEnterEventArgs args)
    {
        lightsAnimator.SetBool("ON", true);
    }

    public void TurnOffWarningLights(SelectExitEventArgs args)
    {

        lightsAnimator.SetBool("ON", false);
    }
}
