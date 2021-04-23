using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpBetweenTwoPoints : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    private float percent;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        percent = Mathf.Sin(Time.time);
        transform.position = AnimMath.Lerp(pointA.position, pointB.position, percent * .99f);
    }
}
