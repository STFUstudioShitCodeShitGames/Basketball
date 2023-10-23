using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MachikFig : MonoBehaviour
{
    private bool _lja;
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (_lja)
            return;
        
        var hla = other.collider.GetComponent<Hulabuba>();
        if (hla == null)
            return;

        _lja = true;
        SceneManager.LoadScene(2);
    }
}