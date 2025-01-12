using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Menu_Buttons : MonoBehaviour
{

    //method to use to load scene1
    public void LoadScene()
    {
        //loads the scene1 using the method called LoadScene
        SceneManager.LoadScene("SampleScene");
    }
}
