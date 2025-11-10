using UnityEngine;
using UnityEngine.SceneManagement;

public class Redo : MonoBehaviour
{
    public void OnRedoClick()
    {
        SceneManager.LoadScene("gameScene");
    }
}