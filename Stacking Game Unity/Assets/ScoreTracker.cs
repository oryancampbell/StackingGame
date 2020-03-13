using System.Collections;
using System.Collections.Generic;
using UnityEngine;






public class ScoreTracker : MonoBehaviour { 
    public ScoreTracker INSTANCE;
    public int bestScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        if(INSTANCE == null)
    {
        INSTANCE = this;
        DontDestroyOnLoad(gameObject);
    }
    else
    {
        Destroy(this.gameObject);
    }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
