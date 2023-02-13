using UnityEngine;
using TMPro;
public class ScoreManager : MonoBehaviour
{

    public TextMeshProUGUI scoreText;
    public static ScoreManager instance;
    private int value = 5;
    public static int score = 0;
    public static int highscore = 0;


    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Puan" + score.ToString();
    }

    public void AddPoint()
    {
        score += value;
        scoreText.text = "Puan " + score.ToString();
    }


}
