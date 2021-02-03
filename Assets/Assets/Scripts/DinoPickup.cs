using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoPickup : MonoBehaviour
{

    public void PlayerInteract()
    {

        Inventory.main.hasDino = true;

        Destroy(gameObject);
    }

}
