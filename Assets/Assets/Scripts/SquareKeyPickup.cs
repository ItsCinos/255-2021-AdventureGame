using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareKeyPickup : MonoBehaviour
{

    public void PlayerInteract()
    {

        Inventory.main.hasSquareKey = true;

        Destroy(gameObject);
    }

}
