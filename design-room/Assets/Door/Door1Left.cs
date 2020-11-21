using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door1Left : MonoBehaviour
{
    private bool isOpened = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        if (isOpened)
        {
            transform.parent.parent.GetComponent<Animation>().PlayQueued("CloseLeft");
            isOpened = false;
        } else {
            transform.parent.parent.GetComponent<Animation>().PlayQueued("OpenLeft");
            isOpened = true;
        }
    }
}
