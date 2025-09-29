using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI score_text;
    public TextMeshProUGUI count_text;
    public static int score = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        score_text.text = "Score :" + score;
        count_text.text = "Count :" + BallController.shootCount;
    }

    public void CountScore()
    {
        Debug.Log("CountScoreの中");
        score++;
    }
}
