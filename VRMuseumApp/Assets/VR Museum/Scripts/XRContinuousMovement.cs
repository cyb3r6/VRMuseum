using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class XRContinuousMovement : MonoBehaviour
{
    [SerializeField]
    private ActionBasedController actionBasedController;

    [SerializeField]
    private XRRig xrRig;

    private Vector3 playerForward;
    private Vector3 playerRight;


    void Start()
    {
        actionBasedController.activateAction.action.performed += Action_performed;
    }

    private void Action_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        xrRig.transform.position += playerForward; 
    }

    void Update()
    {
        playerForward = actionBasedController.transform.forward;
        playerForward.y = 0f;
        playerForward.Normalize();

        playerRight = actionBasedController.transform.right;
        playerRight.y = 0f;
        playerRight.Normalize();
    }

}
