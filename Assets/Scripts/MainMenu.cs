using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MainMenu : MonoBehaviour
{

    EventSystem events;
    
    void Start()
    {
        events = GetComponentInChildren<EventSystem>();
    }

    private void Update()
    {
        if(events.currentSelectedGameObject == null)
        {
            events.SetSelectedGameObject(events.firstSelectedGameObject);
        }
    }

    public void PlayButtonPressed()
    {
        SceneManager.LoadScene("MainLevel");
    }

    public void AboutButtonPressed()
    {
        SceneManager.LoadScene("AboutScreen");
    }

    public void QuitButtonPressed()
    {
        Application.Quit();
    }
}
