using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI score_text;
    int score = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        score_text.text = "Score :" + score;
    }

    public void CountScore()
    {
        Debug.Log("CountScoreの中");
        score++;
    }
}
