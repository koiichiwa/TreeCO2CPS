using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour
{
    public float countdownTime = 30f;
    public string sceneToLoad = "endScreen";
    public TextMeshProUGUI countdownText;

  
    public GameManager gameManager;  

    private float currentTime;

    void Start()
    {
        currentTime = countdownTime;
        UpdateCountdownDisplay();
    }

    void Update()
    {
        currentTime -= Time.deltaTime;

        if (currentTime <= 0f)
        {
            currentTime = 0f;


            if (gameManager != null)
            {
                int finalScore = gameManager.GetCurrentScore();
                PlayerPrefs.SetInt("FinalScore", finalScore);
                PlayerPrefs.Save();
                Debug.Log("Timer saved FinalScore: " + finalScore);
            }
            else
            {
                Debug.LogWarning("GameManager reference not set on CountdownTimer!");
            }

            SceneManager.LoadScene(sceneToLoad);
        }

        UpdateCountdownDisplay();
    }

    void UpdateCountdownDisplay()
    {
        if (countdownText != null)
        {
            countdownText.text = Mathf.Ceil(currentTime).ToString();
        }
    }
}

