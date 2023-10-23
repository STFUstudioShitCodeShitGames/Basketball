using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Nusflbr : MonoBehaviour
{
    private bool _lkga;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (_lkga)
            return;

        _lkga = true;
        SceneManager.LoadScene(2);
    }
}
