using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    private TextMeshProUGUI clockText;
    public long secondsPassed = 0;


    private static GameManager _instance;

    public static GameManager Instance { get { return _instance; } }


    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }



    void Start()
    {
        StartCoroutine(Clock());
    }


    IEnumerator Clock()
    {
        while (true)
        {
            clockText = GameObject.Find("ClockText").GetComponent<TextMeshProUGUI>();
            TimeSpan time = TimeSpan.FromSeconds(secondsPassed);
            string str = time.ToString(@"mm\:ss");

            clockText.text = str;
            secondsPassed++;

            yield return new WaitForSeconds(1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
