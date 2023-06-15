using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System;

public class GameHandler : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject[] squares = new GameObject[10];

    public GameObject TempHandler;
    public TempHandler tempHandler;

    int counter = 0;
    bool whoIsPlaying = false; // True is X, False is O
    int squareBattle = -1;

    void SetText(GameObject gameObject, string str)
    {
        gameObject.GetComponentInChildren<TextMeshProUGUI>().text = str;
    }

    void PlayGame(int square)
    {
        // Debug.Log(squares[square].GetComponentInChildren<TextMeshProUGUI>().text);
        if (squares[square].GetComponentInChildren<TextMeshProUGUI>().text == "") 
        {
            squareBattle = square;
            this.gameObject.SetActive(false);
            TempHandler.SetActive(true);
        }
    }

    void Start()
    {
        for (int i = 0; i < squares.Length; i++)
        {
            string num = (i).ToString();
            squares[i] = GameObject.Find(num);
            SetText(squares[i], "");
            squares[i].GetComponentInChildren<TextMeshProUGUI>().fontSize = 250;
            // Debug.Log(num);
            // Debug.Log(squares[i]);
        }
        if (whoIsPlaying) { SetText(squares[9], "On move is: \n X"); }
        else SetText(squares[9], "On move is: \n O");
        squares[9].GetComponentInChildren<TextMeshProUGUI>().fontSize = 32;
        this.gameObject.SetActive(true);
    }
    public void TempHideSelf()
    {
        this.gameObject.SetActive(false);
        TempHandler.SetActive(true);
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        if (tempHandler.areYouWinningSon)
        {
            if (whoIsPlaying) SetText(squares[squareBattle], "X");
            else SetText(squares[squareBattle], "O");
        }
        whoIsPlaying = !whoIsPlaying;
        // Debug.Log (whoIsPlaying);
        if (whoIsPlaying) { SetText(squares[9], "On move is: \n X"); }
        else SetText(squares[9], "On move is: \n O");
        //SetText(squares[counter], "test please stay " + counter.ToString() + $"(btw we: {tempHandler.areYouWinningSon}");
        //counter++;
    }

    public void SquareOne()
    {
        PlayGame(0);
    }

    public void SquareTwo()
    {
        PlayGame(1);
    }

    public void SquareThree()
    {
        PlayGame(2);
    }

    public void SquareFour()
    {
        PlayGame(3);
    }

    public void SquareFive()
    {
        PlayGame(4);
    }

    public void SquareSix()
    {
        PlayGame(5);
    }

    public void SquareSeven()
    {
        PlayGame(6);
    }

    public void SquareEight()
    {
        PlayGame(7);
    }

    public void SquareNine()
    {
        PlayGame(8);
    }
}
