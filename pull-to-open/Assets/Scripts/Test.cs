using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Test : MonoBehaviour
{
    public UnityEvent test;
    GameObject wire, split1, split2;
    void Start()
    {
        wire.SetActive(true);
        split1.SetActive(false);
        split2.SetActive(false);
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            test.Invoke();
        }
    }
}
