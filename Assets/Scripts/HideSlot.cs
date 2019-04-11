using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideSlot : MonoBehaviour
{
    public GameObject objectToDisable;
    public static bool disabled = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (disabled)
            objectToDisable.SetActive(true);
        else
            objectToDisable.SetActive(false);
    }
}
