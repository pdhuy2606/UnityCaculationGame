using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameScript : MonoBehaviour
{

    public TMPro.TextMeshProUGUI textResult;
    public ThucHanhScript th;

    // Start is called before the first frame update
    public void Start()
    {
        
    }

    public void ClickExit()
    {
        Application.Quit();
    }
    public void ClickStart()
    {
        SceneManager.LoadScene("ThucHanhScene");
    }

}
