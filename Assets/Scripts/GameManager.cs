using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TMP_Text countText;

    int count = 0;

   public void ClickAction()
    {
        count++;
        UpdateUI();
    }

    void UpdateUI()
    {
        countText.text = count.ToString();
    }
}
