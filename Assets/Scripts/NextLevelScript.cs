using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelScript : MonoBehaviour
{
    public string nextLevelScene;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(nextLevelScene);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
