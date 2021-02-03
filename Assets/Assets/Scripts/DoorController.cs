using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public Transform doorArt;

    private float doorAngle = 0;

    public float animLength = 0.5f;
    private float animTimer = 0;
    private bool animIsPlaying = false;

    private bool isClosed = true;

    void Start()
    {

    }

    void Update()
    {
        if (animIsPlaying)
        {
            if (!isClosed)
                animTimer += Time.deltaTime;
            else
                animTimer -= Time.deltaTime;

            float percent = animTimer / animLength;

            if (percent < 0 && isClosed)
            {
                percent = 0;
                animIsPlaying = false;
            }
            if (percent > 1 && !isClosed)
            {
                percent = 1;
                animIsPlaying = false;
            }

            doorArt.localRotation = Quaternion.Euler(0, doorAngle * percent, 0);
        }
    }

    public void PlayerInteract(Vector3 position)
    {
        if (animIsPlaying) return;

        if (!Inventory.main.hasKey) return;

        Vector3 disToPlayer = position - transform.position;
        disToPlayer = disToPlayer.normalized;

        bool playerOnOtherSide = (Vector3.Dot(disToPlayer, transform.forward) > 0);

        isClosed = !isClosed;

        if (!isClosed)
        {
            doorAngle = 90;
            if (playerOnOtherSide) doorAngle = -90;
        }

        if (!isClosed) doorAngle = (playerOnOtherSide) ? -90 : 90;

        animIsPlaying = true;

        if (isClosed) animTimer = animLength;
        else animTimer = 0;
    }
}
