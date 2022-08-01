using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] GameObject Bottons1, Bottons2;
    public void play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void options()
    {
        Bottons1.SetActive(false);
        Bottons2.SetActive(true);
    }
    public void Return()
    {
        Bottons2.SetActive(false);
        Bottons1.SetActive(true);
    }
    public void Exit()
    {
        Application.Quit();
        print("Sali");
    }
}
