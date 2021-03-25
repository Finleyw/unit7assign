using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class General : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void TestButtonSCript( string myMessage )
    {
        Debug.Log( myMessage );
    }

    public void LoadScene(string level)
    { 
        SceneManager.LoadScene(level);
    }

    public void quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
    
}
