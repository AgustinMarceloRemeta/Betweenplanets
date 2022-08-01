using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndManager : MonoBehaviour
{
    [SerializeField] float time, Moneys;
    [SerializeField] Text texto;
    void Update()
    {
        if (PlayerPrefs.GetInt("Money", 0) == Moneys)
            texto.text = "Felicidades conseguiste todas las monedas";
        else texto.text = "Te faltaron " + (Moneys - PlayerPrefs.GetInt("Money", 0)).ToString() + " monedas";
        time -= Time.deltaTime;
        if (time <= 0) SceneManager.LoadScene(0);
    }
}
