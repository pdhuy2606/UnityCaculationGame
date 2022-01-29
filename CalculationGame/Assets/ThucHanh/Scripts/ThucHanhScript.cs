using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ThucHanhScript : MonoBehaviour
{
    public static ThucHanhScript instance;
    public TMPro.TextMeshProUGUI textScore;
    public TMPro.TextMeshProUGUI textTime;

    private int score;
    private int time;

    public GameObject Box;
    public GameObject Ball;
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;
    public float timeToSpawn;

    public bool isPlay = true;
    public bool takeingAway = false;

    // Start is called before the first frame update
    public void Start()
    {
        NewGame();
    }

    void Awake()
    {
        instance = this;
    }
    public void NewGame()
    {
        score = 0;
        time = 20;
        UpdateScore(0);
        textTime.text = "Time : " + time.ToString();
        SpawnRandom();
        InvokeRepeating("SpawnRandom", 1f, timeToSpawn);
    }

    // Update is called once per frame
    void Update()
    {
        UpdateTime();
    }
    

    public void UpdateScore(int scoreAdd)
    {
        score += scoreAdd;
        textScore.text = "Score : " + score.ToString();

    }
    IEnumerator TimeDelay()
    {
        takeingAway = true;
        yield return new WaitForSeconds(1);
        time--;
        textTime.text = "Time : " + time.ToString();
        takeingAway = false;
    } 

    public void UpdateResult()
    {
        if ( score > 20)
        {
            SceneManager.LoadScene("ResultScene");
        }
        else
        {
            SceneManager.LoadScene("ResultScene2");
        }
    }

    public void UpdateTime()
    {
        if (time > 0 && takeingAway == false)
        {
            StartCoroutine(TimeDelay());
        } else if (time==0)
        {
            isPlay = false;           
            UpdateResult();
        }
    }

    public void SpawnRandom()
    {
        if (!isPlay)
            return;

        int rd;
        rd = Random.Range(0, 2);
        if (rd == 0)
        {
            Instantiate(Box,new Vector3(Random.Range(minX,maxX), Random.Range(minY, maxY), 0),Quaternion.identity);
        }
        else Instantiate(Ball,new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), 0), Quaternion.identity);
    }
}
