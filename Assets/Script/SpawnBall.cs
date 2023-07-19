using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBall : MonoBehaviour
{
    public GameObject ballPrefab;
    private MovingRing movingRing_Script;
    private GameManager gameManager_Script;
    public List<GameObject> balls;
    float initialTime = 0;
    float spawnBallthreshold = 1f;

    private void Awake()
    {
        movingRing_Script = FindObjectOfType<MovingRing>();
        gameManager_Script = FindObjectOfType<GameManager>();
        for (int i = 0; i < 4; i++)
        {
            GameObject temp = Instantiate(ballPrefab, transform.position, Quaternion.identity);
            balls.Add(temp);
            temp.transform.SetParent(transform);
        }
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.F) && initialTime < Time.time && (gameManager_Script.ballRemain >= 1))
        {

            movingRing_Script.rotateSpeed += 10;

            gameManager_Script.ballRemainText.text = (--gameManager_Script.ballRemain).ToString("00");
            initialTime = Time.time + spawnBallthreshold;
            for(int i = 0; i < balls.Count; i++)
            {
                if (!balls[i].activeInHierarchy)
                {
                    balls[i].transform.position = transform.position;
                    balls[i].SetActive(true);
                    break;
                }
            }

            if (gameManager_Script.ballRemain == 0)
                gameManager_Script.Invoke("Result", 2f);
        }
    }
}
