using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public RawImage startingScreen;
    public RawImage scoreBoardImage;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI ballRemainText;
    public RawImage resultScreen;
    public TextMeshProUGUI resultText;

    public float score;
    public float ballRemain;

    private void Awake()
    {
        score = 0;
        ballRemain = 10;

        scoreText.text = score.ToString("00");
        ballRemainText.text = ballRemain.ToString("00");

        Invoke("StartingScreenOff", 3f);
    }

    public void Result()
    {
        scoreBoardImage.gameObject.SetActive(false);
        resultScreen.gameObject.SetActive(true);

        if (score == 10)
            resultText.text = "Excellent";
        else if (score >= 7)
            resultText.text = "Good";
        else if (score >= 4)
            resultText.text = "average";
        else if (score >= 1)
            resultText.text = "Bad";
        else
            resultText.text = "Why not try it again?";
    }

    private void StartingScreenOff()
    {
        startingScreen.gameObject.SetActive(false);
    }


    public void ExitGame()
    {
        Application.Quit();
    }

    public void RepeatGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }

}
