using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ControlMenu : MonoBehaviour
{
    public void Menu(string level)
    {
        SceneManager.LoadScene(level);
    }
}
