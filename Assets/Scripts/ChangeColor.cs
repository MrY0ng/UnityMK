using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    private Material Material;
    [SerializeField] private Button RedButton;
    [SerializeField] private Button GreenButton;
    [SerializeField] private Button BlueButton;
    [SerializeField] private Button YellowButton;
    [SerializeField] private GameObject[] Ships = new GameObject[4];

    void Start()
    {
        RedButton.onClick.AddListener(()=>
        {
            Coloring(Color.red);
        });

        GreenButton.onClick.AddListener(()=>
        {
            Coloring(Color.green);
        });

        BlueButton.onClick.AddListener(()=>
        {
            Coloring(Color.blue);
        });

        YellowButton.onClick.AddListener(()=>
        {
            Coloring(Color.yellow);
        });
    }

   
    
    void Coloring(Color color)
    {
        for (int i = 0; i < Ships.Length; i++)
        {
            if (Ships[i].activeSelf)
            {
                Material = Ships[i].gameObject.GetComponent<Renderer>().material;
                Material.color = color;   
            }
        }
    }
    
}
