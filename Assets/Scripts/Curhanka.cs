using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Curhanka : MonoBehaviour
{
    private void Awake()
    {
        Application.targetFrameRate = 120;
    }

    public void OnTudu()
    {
        SceneManager.LoadScene(1);
    }

    public void PokaPako()
    {
        Application.Quit();
    }
}
