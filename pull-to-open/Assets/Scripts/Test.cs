using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Test : MonoBehaviour
{
    public UnityEvent cut;
    GameObject wire, split1, split2;
    void Start()
    {
        wire.SetActive(true);
        split1.SetActive(false);
        split2.SetActive(false);
    }  
    void Update()
    {
        InteractRaycast();
    }

    void InteractRaycast()
    {
        Vector3 playerPosition = transform.position;
        Vector3 forwardDirection = transform.forward;

        Ray interactionRay = new Ray(playerPosition, forwardDirection);
        RaycastHit interactionRayHit;
        float interactionRayLength = 5.0f;

        Vector3 interactionRayEndpoint = forwardDirection * interactionRayLength;
        Debug.DrawLine(playerPosition, interactionRayEndpoint);

        bool hitFound = Physics.Raycast(interactionRay, out interactionRayHit, interactionRayLength);
        if (hitFound)
        {
            GameObject hitGameObject = interactionRayHit.transform.gameObject;
            if (hitGameObject.CompareTag("Wire") == true && Input.GetKeyDown(KeyCode.Mouse0))
            {
                cut.Invoke();
            }
        }

    }
}
