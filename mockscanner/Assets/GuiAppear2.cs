using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections.Generic;

public class GraphicRaycasterExample : MonoBehaviour
{
    GraphicRaycaster m_Raycaster;
    PointerEventData m_PointEventData;
    EventSystem m_EventSystem;

     void Start()
    {
        m_Raycaster = GetComponent<GraphicRaycaster>();
        m_EventSystem = GetComponent<EventSystem>();

    }

    void Update()
    {
        
    }
}
