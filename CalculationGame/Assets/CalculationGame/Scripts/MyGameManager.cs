﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MyGameManager : MonoBehaviour
{
    #region fields
    public TMPro.TextMeshProUGUI textResult;
    public TMPro.TextMeshProUGUI textQuestion;
    public TMPro.TextMeshProUGUI textScore;
    //  public TMPro.TMP_InputField infiResult;
    private float result;
    private float answer;

    private float fill;
    private float fill2;
    private float score;

    private float numA;
    private float numB;
    private float operation;
    private string operationS;
    #endregion fields


    #region Methods
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        UpdateScore();
        RandomQuestion();
    }


    public void RandomQuestion()
    {
        numA = Random.Range(0, 100);
        numB = Random.Range(0, 100);
        operation = Random.Range(0, 2);
        if (operation == 0)
        {
            operationS = "+";
            result = numA + numB;
            textQuestion.text = numA.ToString() + " + " + numB.ToString() + " = ?";
        }
        else
        {
            operationS = "-";
            if (numA > numB)
            {
                result = numA - numB;
                textQuestion.text = numA.ToString() + " - " + numB.ToString() + " = ?";
            }
            else
            {
                result = numB - numA;
                textQuestion.text = numB.ToString() + " - " + numA.ToString() + " = ?";
            }

        }

    }
    
    public void ClickNumber(int val)
    {
        Debug.Log($"check val: {val}");
        textResult.text += $"{val}";
        answer = float.Parse(textResult.text);
        if (fill == 0)
        {
            fill = val;
        }
        else
        {
            fill2 = val;
        }
    }

    public void ClearResult()
    {
        //  Debug.Log($"check val: {val}");
        textResult.text = "";
    }

    public void ClickExit()
    {
        Application.Quit();
    }
    public void ClickSubmit()
    {
        if (answer == result)
        {
            score += 1;

        }
        else
        {

        }
        UpdateScore();
        RandomQuestion();
        ClearResult();
    }
    public void ClickSkip()
    {
        score -= 1;
        RandomQuestion();
        ClearResult();
        UpdateScore();
    }
    public void UpdateScore()
    {
        textScore.text = score.ToString();
    }
    #endregion  Methods

    #region Events

    #endregion Events
    //// Update is called once per frame
    //void Update()
    //{

    //}

}
