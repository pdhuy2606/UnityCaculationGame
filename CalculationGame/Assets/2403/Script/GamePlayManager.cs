using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;


public class GamePlayManager : MonoBehaviour
{
    public AudioSource audio1;
    public VideoPlayer congrat;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col1)
    {
        Debug.Log(gameObject.name + "  OnTriggerEnter2D with " + col1.gameObject.name);
        audio1.Play();

    }


    private void OnCollisionEnter2D(Collision2D col2)
    {
        Debug.Log(gameObject.name + "  OnCollisionEnter2D with " + col2.gameObject.name);
        audio1.Play();

        
        if (gameObject.tag == "FinishTag")
        {
            congrat.Play();
            audio1.mute = true;
        }
       
;
    }
}
