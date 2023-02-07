using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MiniMap : MonoBehaviour
{
    [SerializeField] private GameObject Camera;
    [SerializeField] private Button UpButton;
    [SerializeField] private Button FaceButton;
    [SerializeField] private Button DownButton;
    [SerializeField] private Button LeftButton;

    void Start()
    {
        UpButton.onClick.AddListener(()=>
        {
            Camera.transform.position = new Vector3 (3.8f, 144, 409);
            Camera.transform.rotation = Quaternion.AngleAxis(90.0f, Vector3.right);
            
        });
        
        FaceButton.onClick.AddListener(()=>
        {
            Camera.transform.position = new Vector3 (0, -103, 200);
            Camera.transform.rotation = Quaternion.AngleAxis(0.0f, Vector3.up);
        });

        DownButton.onClick.AddListener(()=>
        {
            Camera.transform.position = new Vector3 (3.8f, -393, 409);
            Camera.transform.rotation = Quaternion.AngleAxis(90.0f, Vector3.left);
        });
        
        LeftButton.onClick.AddListener(()=>
        {
            Camera.transform.position = new Vector3 (256, -111, 409);
            Camera.transform.rotation = Quaternion.AngleAxis(-90.0f, Vector3.up);
        });
    }
}
