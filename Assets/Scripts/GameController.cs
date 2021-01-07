using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
    
    // Start is called before the first frame update
    void Start() {
    }

    // Update is called once per frame
    private void Update() {
        if (Input.GetButtonDown("Cancel")) { GoBack(); }
    }

    public void GoBack() {
        SceneManager.LoadScene("Menu");
    }
    
}
