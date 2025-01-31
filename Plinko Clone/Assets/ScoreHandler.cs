using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreHandler : MonoBehaviour
{
    public float scoreFlat;
    public float scoreMult;
    
    public TextMeshProUGUI scoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreFlat = 50;
        scoreMult = 1;
        updateScoreText();
    }

    // Update is called once per frame
    void Update()
    {
        updateScoreText();
    }

    void updateScoreText()
    {
        float score = scoreFlat * scoreMult;
        scoreText.text = scoreFlat.ToString() + " x " + scoreMult.ToString() + "\nScore: " + score.ToString();
    }
}
