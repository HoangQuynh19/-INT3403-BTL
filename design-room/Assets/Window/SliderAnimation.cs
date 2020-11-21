using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderAnimation : MonoBehaviour
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
            if (m_collider.name.Equals("Slider"))
            {
                m_animation.PlayQueued("SliderLClose");
            } else {
                m_animation.PlayQueued("SliderRClose");
            }
            isOpened = false;
        } else {
            if (m_collider.name.Equals("Slider"))
            {
                m_animation.PlayQueued("SliderLOpen");
            } else {
                m_animation.PlayQueued("SliderROpen");
            }
            isOpened = true;
        }
    }
}
