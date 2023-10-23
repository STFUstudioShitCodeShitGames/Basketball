using System;
using UnityEngine;

public class Hulabuba : MonoBehaviour
{
    [SerializeField] private float _chukUp;
    [SerializeField] private float _chukStor;
    private Rigidbody2D _kilkjsad;
    private Rigidbody2D Khhs => _kilkjsad ??= GetComponent<Rigidbody2D>();

    private Vector2 _jumbaSmotr = Vector2.right;

    private void Update()
    {
        if (Input.touchCount == 0)
            return;

        var hlub = Input.GetTouch(0);
        if (hlub.phase != TouchPhase.Ended)
            return;

        VerUponchick();
    }

    private void VerUponchick()
    {
        Khhs.velocity = Vector2.zero;
        Khhs.angularVelocity = 0;
        Khhs.totalTorque = 0;
        
        Khhs.AddTorque(-_jumbaSmotr.x, ForceMode2D.Impulse);
        Khhs.AddForce((Vector2.up * _chukUp) + (_jumbaSmotr * _chukStor) , ForceMode2D.Impulse);
    }

    private const string Purpacept = "Left";
    private const string AntiFres = "Right";
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.CompareTag(Purpacept))
            _jumbaSmotr = Vector2.right;
        
        if (other.collider.CompareTag(AntiFres))
            _jumbaSmotr = Vector2.left;
    }
}