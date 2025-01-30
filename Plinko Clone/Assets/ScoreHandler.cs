using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreHandler : MonoBehaviour
{
    public float score;
    
    public TextMeshProUGUI scoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score = 50;
        updateScoreText();
    }

    // Update is called once per frame
    void Update()
    {
        updateScoreText();
    }

    void updateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}
