using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    private GameManager gameManager_Script;

    private void Awake()
    {
        gameManager_Script = FindObjectOfType<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag(NameManager.BALL_TAG))
        {
            gameManager_Script.scoreText.text = (++gameManager_Script.score).ToString("00");
            other.gameObject.SetActive(false);
            other.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
    }
}
