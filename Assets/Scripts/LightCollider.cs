using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightCollider : MonoBehaviour
{
    public LightManager lightManager;

    private void OnTriggerStay(Collider other)
    {
        Vector3 playerPos = other.transform.position - gameObject.transform.position;
        Vector3 lightPos = new Vector3(0, -1, 0);
        float angle = Vector3.Angle(playerPos, lightPos);
        if (Mathf.Abs(angle/3) < gameObject.GetComponent<Light>().spotAngle)
        {
            int layerMask = 1 << 7 ;
            layerMask = ~layerMask;
            RaycastHit hit;
            // Does the ray intersect any objects excluding the player layer
            if (Physics.Raycast(transform.position, playerPos, out hit, Mathf.Infinity, layerMask))
            {
                if (hit.transform.gameObject.tag == "Player")
                  lightManager.isInShadow(true);
            }
        }
        else 
        {
            lightManager.isInShadow(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        lightManager.isInShadow(false);
    }
    
}
