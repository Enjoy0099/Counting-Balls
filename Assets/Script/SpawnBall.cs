using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBall : MonoBehaviour
{
    public GameObject ballPrefab;
    public List<GameObject> balls;

    private void Awake()
    {
        for (int i = 0; i < 9; i++)
        {
            GameObject temp = Instantiate(ballPrefab, transform.position, Quaternion.identity);
            balls.Add(temp);
            temp.transform.SetParent(transform);
        }
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            for(int i = 0; i < balls.Count; i++)
            {
                if (!balls[i].activeInHierarchy)
                {
                    balls[i].transform.position = transform.position;
                    balls[i].SetActive(true);
                    break;
                }
            }
        }
    }
}
