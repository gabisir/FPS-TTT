using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempHandler : MonoBehaviour
{
    public GameObject GameObject;

    public bool areYouWinningSon = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Win()
    {
        areYouWinningSon = true;
        GameObject.SetActive(true);
    }
    public void Lose()
    {
        areYouWinningSon = false;
        GameObject.SetActive(true);
    }
}
