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
    public GameObject CrossHair;

    int counter = 0;
    bool whoIsPlaying = true; // True is X, False is O
    int squareBattle = -1;
    bool started = false;

    void SetText(GameObject gameObject, string str)
    {
        if (gameObject == null) return;
        gameObject.GetComponentInChildren<TextMeshProUGUI>().text = str;
    }

    string GetText(GameObject gameObject)
    {
        if (gameObject == null) { Debug.Log("Object not found!"); return ""; }
        return gameObject.GetComponentInChildren<TextMeshProUGUI>().text;
    }

    char[] GetCharArrayFromGrid(GameObject[] gameObjects)
    {
        Debug.Log(gameObjects.Length - 1);
        char[] array = new char[gameObjects.Length - 1];
        for (int i = 0; i < gameObjects.Length - 1; i++)
        {
            array[i] = GetText(gameObjects[i]).ToCharArray()[0];
            Debug.Log(array[i]);
            Debug.Log(GetText(gameObjects[i]).ToCharArray());
        }
        return array;
    }

    private static int CheckWin(char[] arr)
    {
        #region Horzontal Winning Condtion
        //Winning Condition For First Row
        if (arr[1] == arr[2] && arr[2] == arr[3])
        {
            return 1;
        }
        //Winning Condition For Second Row
        else if (arr[4] == arr[5] && arr[5] == arr[6])
        {
            return 2;
        }
        //Winning Condition For Third Row
        else if (arr[6] == arr[7] && arr[7] == arr[8])
        {
            return 3;
        }
        #endregion
        #region vertical Winning Condtion
        //Winning Condition For First Column
        else if (arr[1] == arr[4] && arr[4] == arr[7])
        {
            return 4;
        }
        //Winning Condition For Second Column
        else if (arr[2] == arr[5] && arr[5] == arr[8])
        {
            return 5;
        }
        //Winning Condition For Third Column
        else if (arr[3] == arr[6] && arr[6] == arr[9])
        {
            return 6;
        }
        #endregion
        #region Diagonal Winning Condition
        else if (arr[1] == arr[5] && arr[5] == arr[9])
        {
            return 7;
        }
        else if (arr[3] == arr[5] && arr[5] == arr[7])
        {
            return 8;
        }
        #endregion
        #region Checking For Draw
        // If all the cells or values filled with X or O then any player has won the match
        else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9')
        {
            return -1;
        }
        #endregion
        else
        {
            return 0;
        }
    }


    void PlayGame(int square)
    {
        // Debug.Log(squares[square].GetComponentInChildren<TextMeshProUGUI>().text);
        if (GetText(squares[square]) == "") 
        {
            squareBattle = square;
            this.gameObject.SetActive(false);
            CrossHair.SetActive(true);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
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
        started = true;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        CrossHair.SetActive(false);

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
        if (started)
        {
            if (tempHandler.areYouWinningSon)
            {
                if (whoIsPlaying) SetText(squares[squareBattle], "X");
                else SetText(squares[squareBattle], "O");
            }
            int winSection = CheckWin(GetCharArrayFromGrid(squares));
            if (winSection > 0)
            {
                SetText(squares[9], $"Player {(whoIsPlaying ? 'X' : '0')} won on section {winSection}");
            }
            whoIsPlaying = !whoIsPlaying;
            // Debug.Log (whoIsPlaying);
            if (whoIsPlaying) { SetText(squares[9], "On move is: \n X"); }
            else SetText(squares[9], "On move is: \n O");
            //SetText(squares[counter], "test please stay " + counter.ToString() + $"(btw we: {tempHandler.areYouWinningSon}");
            //counter++;
        }
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
