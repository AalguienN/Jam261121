using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ControlMenu : MonoBehaviour
{
    public void Menu(string level)
    {
        print("Menu " + level);
        SceneManager.LoadScene(level);
    }

}