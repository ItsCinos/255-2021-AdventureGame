using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleKeyPickup : MonoBehaviour
{

    public void PlayerInteract()
    {

        Inventory.main.hasTriangleKey = true;

        Destroy(gameObject);
    }

}
