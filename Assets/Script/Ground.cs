using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.SetActive(false);
        other.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
    }
}
