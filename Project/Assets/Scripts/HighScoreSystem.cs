using UnityEngine;
using UnityEngine.UI;

public class HighScoreSystem : MonoBehaviour
{
    [SerializeField] Score score;
    public NameInput name;

    public Text highScore1;
    public Text highScore2;
    public Text highScore3;
    public Text highScore4;
    public Text Scorename1;
    public Text Scorename2;
    public Text Scorename3;
    public Text Scorename4;

  

    // Update is called once per frame
    public void HighScore()
    {
        if (score.scorePlayer1 > PlayerPrefs.GetInt("HighScore1", 0))
        {
            PlayerPrefs.SetInt("HighScore4", PlayerPrefs.GetInt("HighScore3", 0));
            PlayerPrefs.SetInt("HighScore3", PlayerPrefs.GetInt("HighScore2", 0));
            PlayerPrefs.SetInt("HighScore2", PlayerPrefs.GetInt("HighScore1", 0));
            PlayerPrefs.SetInt("HighScore1", score.scorePlayer1);

            PlayerPrefs.SetString("HS4Name", PlayerPrefs.GetString("HS3Name", ""));
            PlayerPrefs.SetString("HS3Name", PlayerPrefs.GetString("HS2Name", ""));
            PlayerPrefs.SetString("HS2Name", PlayerPrefs.GetString("HS1Name", ""));
            PlayerPrefs.SetString("HS1Name", name.player1);
        }
        else if (score.scorePlayer1 > PlayerPrefs.GetInt("HighScore2", 0))
        {
            PlayerPrefs.SetInt("HighScore4", PlayerPrefs.GetInt("HighScore3", 0));
            PlayerPrefs.SetInt("HighScore3", PlayerPrefs.GetInt("HighScore2", 0));
            PlayerPrefs.SetInt("HighScore2", score.scorePlayer1);

            PlayerPrefs.SetString("HS4Name", PlayerPrefs.GetString("HS3Name", ""));
            PlayerPrefs.SetString("HS3Name", PlayerPrefs.GetString("HS2Name", ""));
            PlayerPrefs.SetString("HS2Name", name.player1);
        }
        else if (score.scorePlayer1 > PlayerPrefs.GetInt("HighScore3", 0))
        {
            PlayerPrefs.SetInt("HighScore4", PlayerPrefs.GetInt("HighScore3", 0));
            PlayerPrefs.SetInt("HighScore3", score.scorePlayer1);

            PlayerPrefs.SetString("HS4Name", PlayerPrefs.GetString("HS3Name", ""));
            PlayerPrefs.SetString("HS3Name", name.player1);
        }
        else if (score.scorePlayer1 > PlayerPrefs.GetInt("HighScore4", 0))
        {
            PlayerPrefs.SetInt("HighScore4", score.scorePlayer1);

            PlayerPrefs.SetString("HS3Name", name.player1);
        }
        highScore1.text = PlayerPrefs.GetInt("HighScore1", 0).ToString();
        highScore2.text = PlayerPrefs.GetInt("HighScore2", 0).ToString();
        highScore3.text = PlayerPrefs.GetInt("HighScore3", 0).ToString();
        highScore4.text = PlayerPrefs.GetInt("HighScore4", 0).ToString();
        Scorename1.text = PlayerPrefs.GetString("HS1Name", "n/a").ToString();
        Scorename2.text = PlayerPrefs.GetString("HS2Name", "n/a").ToString();
        Scorename3.text = PlayerPrefs.GetString("HS3Name", "n/a").ToString();
        Scorename4.text = PlayerPrefs.GetString("HS4Name", "n/a").ToString();
    }
}
