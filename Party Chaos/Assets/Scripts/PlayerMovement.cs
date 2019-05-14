using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Input;


public class PlayerMovement : MonoBehaviour
{
    private InputMaster controls;

    void Awake()
    {
        controls.Player.Movement.performed += context => Movement();
    }

    void Movement ()
    {
        Debug.Log("We moved!");
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }
}
