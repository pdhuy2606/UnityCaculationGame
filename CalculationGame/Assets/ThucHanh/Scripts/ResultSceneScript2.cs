using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultSceneScript2 : MonoBehaviour
{

    public TMPro.TextMeshProUGUI textResult;
    public ThucHanhScript th;

    // Start is called before the first frame update
     void Start()
    {
        textResult.text = "LOSE";
    }

    

    public void ClickExit()
    {
        Application.Quit();
    }
    public void ClickRestart()
    {
        SceneManager.LoadScene("ThucHanhScene");
    }

}
