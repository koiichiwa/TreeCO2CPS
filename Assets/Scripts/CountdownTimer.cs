
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{

    public float countdownTime = 30f;  
    public string sceneToLoad = "endScreen";
    public TextMeshProUGUI countdownText;

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


