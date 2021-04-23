using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Inventory : MonoBehaviour
{
    private static Inventory _main;
    public static Inventory main
    {
        get { return _main; }
    }

    public bool hasKey = false;
    public bool hasCircleKey = false;
    public bool hasSquareKey = false;
    public bool hasTriangleKey = false;
    public bool hasDino = false;

    private void Start()
    {
        if (_main == null)
        {
            _main = this;
            DontDestroyOnLoad(gameObject);
            //dont destroy object when loading new scene

        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        if (hasDino)
        {
            SceneManager.LoadScene("EndScene");
            hasDino = false;
        }
    }
}
