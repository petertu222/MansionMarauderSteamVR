using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory3 : MonoBehaviour
{
    public bool[] isFull;
    public GameObject[] slots;

    void Update()
    {
        Enable();
    }

    void Enable()
    {
        if (Input.GetKey(KeyCode.I))
        {
            HideSlot.disabled = true;
        }

        else 
        {
            HideSlot.disabled = false;
        }
    }

}

