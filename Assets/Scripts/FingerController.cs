using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class FingerController : MonoBehaviour
{
 
    public Vector3 initialRot;
    public Vector3 initialSca;
    public static FingerController instance;
    IEnumerator ie;
    void Awake()
    {
        instance = this;
    }
    
    void Update()
    {
       
        if (Input.touchCount == 0)
        {
            if (ie != null)
            {
                StopCoroutine(ie);
                ie = null;
            }
        }
        else if (Input.touchCount == 1)
        {
                if (ie != null)
                {
                    StopCoroutine(ie);
                }
                ie = IMonitorMouseOneFinger();
                StartCoroutine(ie);
        }
        
        
    }
   
    IEnumerator IMonitorMouseOneFinger()
    {
 
        Touch oneFingerTouch;
        while (true)
        {
            oneFingerTouch = Input.GetTouch(0);
            if (oneFingerTouch.phase == TouchPhase.Moved)
            {
                Vector2 deltaPos = oneFingerTouch.deltaPosition;
                transform.Rotate(-Vector3.up * deltaPos.x * 0.2f, Space.World);
                
            }
            yield return 0;
        }
    }
}