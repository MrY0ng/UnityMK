using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeShips : MonoBehaviour
{
    [SerializeField] private Button LeftButton;
    [SerializeField] private Button RightButton;
    [SerializeField] private GameObject[] Ships = new GameObject[4];
    private int shipIndex;
    void Start()
    {
        shipIndex = 0;
        RightButton.onClick.AddListener(()=>
        {
            ChangeShip(1);
        });

        LeftButton.onClick.AddListener(()=>
        {
            ChangeShip(-1);
        });
    }

    void ChangeShip(int offset)
    {
        for (int i = 0; i < Ships.Length; i++)
        {
            Ships[i].SetActive(false);
        }

        Ships[shipIndex].SetActive(true);
        Ships[shipIndex].transform.position = new Vector3(-1, -107, 398);
        shipIndex += offset;   
        shipIndex = MathMod(shipIndex, Ships.Length);
        /*if (shipIndex == Ships.Length)
        {
            shipIndex = 0;
        }
        if (shipIndex == -1)
        {
            shipIndex = Ships.Length-1;
        }*/

        Debug.Log(shipIndex);
    }

    int MathMod(int a, int b) 
    {
        return (Mathf.Abs(a * b) + a) % b;
    }
}


