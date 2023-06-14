using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameHandler : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject[] squares = new GameObject[9];

    public TempHandler tempHandler;

    int counter = 0;

    void SetText(GameObject gameObject, string str)
    {
        gameObject.GetComponentInChildren<TextMeshProUGUI>().text = str;
    }

    void Start()
    {
        for (int i = 0; i < squares.Length; i++)
        {
            string num = (i).ToString();
            squares[i] = GameObject.Find(num);
            SetText(squares[i], "");
            Debug.Log(num);
            Debug.Log(squares[i]);
        }
        this.gameObject.SetActive(false);
    }

   

    public void TempHideSelf()
    {
        this.gameObject.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        SetText(squares[counter], "test please stay " + counter.ToString() + $"(btw we: {tempHandler.areYouWinningSon}");
        counter++;
    }
}
