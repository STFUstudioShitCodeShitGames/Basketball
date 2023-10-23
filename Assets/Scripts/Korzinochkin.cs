using System;
using UnityEngine;

public class Korzinochkin : MonoBehaviour
{
    [SerializeField] private float _kukumba;
    [SerializeField] private Rigidbody2D _sadda;

    private void FixedUpdate()
    {
        var ukrrr = _sadda.position + Vector2.up * Time.deltaTime * _kukumba;
        _sadda.MovePosition(ukrrr);
    }
    
    private void OnTriggerExit2D(Collider2D other)
    {
        if (!other.gameObject.CompareTag("Player"))
            return;
        
        Scorchilsa?.Invoke();
        Destroy(gameObject);
    }

    public event Action Scorchilsa;
}