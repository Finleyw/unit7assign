using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine;

public class General : MonoBehaviour
{
    public GameObject menuFirst, optionsFirst, difficultyFirst, loadFirst,audioFirst,h2pFirst;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MenuNav()
    {
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(menuFirst);
    }
    
    public void OptionsNav()
    {
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(optionsFirst);
    }
    public void DifficultyNav()
    {
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(difficultyFirst);
    }
    public void LoadNav()
    {
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(loadFirst);
    }
    public void AudioNav()
    {
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(audioFirst);
    }
    public void H2pNav()
    {
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(h2pFirst);
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
