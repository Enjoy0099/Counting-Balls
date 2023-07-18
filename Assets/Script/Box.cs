using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag(NameManager.BALL_TAG))
        {
            other.gameObject.SetActive(false);
            other.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
    }
}
