using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    private void Start() {
        Cursor.lockState = CursorLockMode.None;
    }

    public void PlayGame() {
        SceneManager.LoadScene("Game");
    }

    public void QuitGame() {
        Application.Quit();
    }

    public void SetNoCandles(float number) {
        int realNumber = (int) (number * 522);
        StateController.NoCandles = realNumber;
        Debug.Log(StateController.NoCandles);
    }
}
