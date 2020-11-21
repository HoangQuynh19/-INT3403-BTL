using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowAnimation : MonoBehaviour
{
    private bool isOpened = false;
    private Animation m_animation;
    private Collider m_collider;
    
    // Start is called before the first frame update
    void Start()
    {
        Transform node = transform;
        while (node.GetComponent<Animation>() == null) node = node.parent;
        m_animation = node.GetComponent<Animation>();
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
            if (m_collider.name.Equals("Window.L"))
            {
                m_animation.PlayQueued("Window.LClose");
            } else {
                m_animation.PlayQueued("Window.RClose");
            }
            isOpened = false;
        } else {
            if (m_collider.name.Equals("Window.L"))
            {
                m_animation.PlayQueued("Window.LOpen");
            } else {
                m_animation.PlayQueued("Window.ROpen");
            }
            isOpened = true;
        }
    }
}
