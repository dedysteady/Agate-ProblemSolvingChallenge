using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text score;
    private int currentScore;
    public Text gameoverScore;

    // Start is called before the first frame update
    private void Start()
    {
        currentScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        score.text = $"Score : { currentScore.ToString("0") }";
    }

    public void IncreaseCurrentScore(int num)
    {
        currentScore += num;
    }

    public void EndScore()
    {
        gameoverScore.text = $"Score : { currentScore.ToString("0") }";
        SoundManager.Instance.PlayGame();    
    }
}
