using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandleGenerator : MonoBehaviour {
    private int startZ = -33;
    private int endZ = -16;
    private int startX = 34;
    private int endX = 6;
    private float y = 3.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(StateController.NoCandles);
        int noCandles = StateController.NoCandles;
        Debug.Log(noCandles);
        GameObject prefab = Resources.Load("Candle") as GameObject;
        
        for (int z = startZ; z <= endZ; z += 1) {
            for (int x = startX; x >= endX; x -= 1) {
                if (noCandles <= 0) { return; }
                Instantiate(prefab, new Vector3(x, y, z), new Quaternion());
                noCandles -= 1;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
