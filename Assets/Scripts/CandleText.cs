using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CandleText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TextMeshProUGUI textMesh = GetComponent<TextMeshProUGUI>();
        textMesh.text = "0 Candles";
    }

    // Update is called once per frame
    void Update() {
        TextMeshProUGUI textMesh = GetComponent<TextMeshProUGUI>();
        textMesh.text = StateController.NoCandles.ToString() + " Candles";
    }
}
