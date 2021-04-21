using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]

public class Raycaster : MonoBehaviour
{
    private Camera cam;

    void Start()
    {
        cam = GetComponent<Camera>();
    }

    void Update()
    {


        if (cam != null && Input.GetButtonDown("Fire1"))
        {

            Ray ray = new Ray(cam.transform.position, cam.transform.forward);
            RaycastHit hit;

            //Debug.DrawRay(ray.origin, ray.direction, Color.black, .5f);

            if (Physics.Raycast(ray, out hit))
            {
                CircleDoorController circleDoor = hit.transform.GetComponentInParent<CircleDoorController>();
                if (circleDoor != null) circleDoor.PlayerInteract(transform.parent.position);

                SquareDoorController squareDoor = hit.transform.GetComponentInParent<SquareDoorController>();
                if (squareDoor != null) squareDoor.PlayerInteract(transform.parent.position);

                TriangleDoorController triangleDoor = hit.transform.GetComponentInParent<TriangleDoorController>();
                if (triangleDoor != null) triangleDoor.PlayerInteract(transform.parent.position);

                ItemPickup pickup = hit.transform.GetComponent<ItemPickup>();
                if (pickup != null) pickup.PlayerInteract();

                CircleKeyPickup circleKey = hit.transform.GetComponent<CircleKeyPickup>();
                if (circleKey != null) circleKey.PlayerInteract();

                SquareKeyPickup squareKey = hit.transform.GetComponent<SquareKeyPickup>();
                if (squareKey != null) squareKey.PlayerInteract();

                TriangleKeyPickup triangleKey = hit.transform.GetComponent<TriangleKeyPickup>();
                if (triangleKey != null) triangleKey.PlayerInteract();

                DinoPickup dinoPickup = hit.transform.GetComponent<DinoPickup>();
                if (dinoPickup != null) dinoPickup.PlayerInteract();

            }
        }
    }
}
