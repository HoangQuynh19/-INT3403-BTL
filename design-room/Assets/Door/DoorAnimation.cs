using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnimation : MonoBehaviour
{
    private bool isOpened = false;
    private Animation parentAnimation;
    private Collider m_collider;
    
    // Start is called before the first frame update
    void Start()
    {
        parentAnimation = transform.parent.parent.GetComponent<Animation>();
        m_collider = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        if (isOpened)
        {
            if (m_collider.name.Equals("Door"))
            {
                parentAnimation.PlayQueued("CloseRight");
            } else {
                parentAnimation.PlayQueued("CloseLeft");
            }
            isOpened = false;
        } else {
            if (m_collider.name.Equals("Door"))
            {
                parentAnimation.PlayQueued("OpenRight");
            } else {
                parentAnimation.PlayQueued("OpenLeft");
            }
            isOpened = true;
        }
    }
}
