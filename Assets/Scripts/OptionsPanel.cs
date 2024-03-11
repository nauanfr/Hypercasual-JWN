using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OptionsPanel : MonoBehaviour
{
    public GameObject optionsPanel;

    private bool isPaused = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TogglePauseMenu()
    {
        isPaused = !isPaused;
        optionsPanel.SetActive(isPaused);
        Time.timeScale = isPaused ? 0 : 1;
    }


}
