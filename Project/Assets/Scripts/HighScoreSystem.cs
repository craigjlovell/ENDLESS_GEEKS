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
    public Text Scorename;
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
            PlayerPrefs.SetString("player1", name.player1);
        }
        highScore1.text = PlayerPrefs.GetInt("HighScore1", 0).ToString();
        highScore2.text = PlayerPrefs.GetInt("HighScore2", 0).ToString();
        highScore3.text = PlayerPrefs.GetInt("HighScore3", 0).ToString();
        highScore4.text = PlayerPrefs.GetInt("HighScore4", 0).ToString();
        Scorename.text = PlayerPrefs.GetString("player1", name.player1.ToString()).ToString();
    }
}
