using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndManager : MonoBehaviour
{
    [SerializeField] float time;
    void Update()
    {
        time -= Time.deltaTime;
        if (time <= 0) SceneManager.LoadScene(0);
    }
}