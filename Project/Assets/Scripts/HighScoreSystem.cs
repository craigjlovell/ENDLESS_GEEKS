using UnityEngine;
using UnityEngine.UI;

public class HighScoreSystem : MonoBehaviour
{
    [SerializeField] Score score;

    public Text highScore1;
    public Text highScore2;
    public Text highScore3;
    int bigScore;

    public void HighScore()
    {
        if (score.scorePlayer1 > score.scorePlayer2)
        {
            bigScore = score.scorePlayer1;
        }
        else
        {
            bigScore = score.scorePlayer2;
        }
        HighScoreList();
        highScore1.text = PlayerPrefs.GetInt("HighScore1", 0).ToString();
        highScore2.text = PlayerPrefs.GetInt("HighScore2", 0).ToString();
        highScore3.text = PlayerPrefs.GetInt("HighScore3", 0).ToString();
    }

    void HighScoreList()
    {
        if (bigScore > PlayerPrefs.GetInt("HighScore1", 0))
        {
            PlayerPrefs.SetInt("HighScore3", PlayerPrefs.GetInt("HighScore2", 0));
            PlayerPrefs.SetInt("HighScore2", PlayerPrefs.GetInt("HighScore1", 0));
            PlayerPrefs.SetInt("HighScore1", bigScore);
        }
        else if (bigScore > PlayerPrefs.GetInt("HighScore2", 0))
        {
            PlayerPrefs.SetInt("HighScore3", PlayerPrefs.GetInt("HighScore2", 0));
            PlayerPrefs.SetInt("HighScore2", bigScore);
        }
        else if (bigScore > PlayerPrefs.GetInt("HighScore3", 0))
        {
            PlayerPrefs.SetInt("HighScore3", bigScore);
        }
    }
}
