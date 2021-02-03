using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerInventoryGUI : MonoBehaviour
{
    public Transform imgCircleKey;
    public Transform imgSquareKey;
    public Transform imgTriangleKey;
    public Transform imgDino;

    void Update()
    {
        imgCircleKey.gameObject.SetActive(Inventory.main.hasCircleKey);
        imgSquareKey.gameObject.SetActive(Inventory.main.hasSquareKey);
        imgTriangleKey.gameObject.SetActive(Inventory.main.hasTriangleKey);
        imgDino.gameObject.SetActive(Inventory.main.hasDino);
    }
}
