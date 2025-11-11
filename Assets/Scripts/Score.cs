using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    
    public TMP_Text finalScoreText;

    void Start()
    {
      
        int finalScore = PlayerPrefs.GetInt("FinalScore", 0);
        Debug.Log("Loaded FinalScore: " + finalScore);

        if (finalScoreText != null)
        {
            finalScoreText.text = finalScore.ToString() + " grams";
        }
    }
}