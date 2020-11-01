using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Restart : MonoBehaviour
{
    public Button restart;

    void Start()
    {
        Button btn = restart.GetComponent<Button>();
        btn.onClick.AddListener(OnRestart);
    }

    void OnRestart()
    {
        Player.Restart();
        SceneManager.LoadScene("MainScene");
    }
}
