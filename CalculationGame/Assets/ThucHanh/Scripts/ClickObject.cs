using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickObject : MonoBehaviour
{
    public int scoreAdd;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void AddScore()
    {
        ThucHanhScript.instance.UpdateScore(scoreAdd);
    }

    public void OnMouseDown()
    {
        AddScore();
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
