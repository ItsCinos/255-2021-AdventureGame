using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleKeyPickup : MonoBehaviour
{

    public void PlayerInteract()
    {

        Inventory.main.hasCircleKey = true;

        Destroy(gameObject);
    }

}
