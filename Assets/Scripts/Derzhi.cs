using TMPro;
using UnityEngine;

public class Derzhi : MonoBehaviour
{
    [SerializeField] private Korzinochkin _korzinochkin;
    [SerializeField] private float _ukaShir;
    [SerializeField] private float _mikaShir;
    [SerializeField] private float _chutka;
    [SerializeField] private Orgi _rurur;
    [SerializeField] private RectTransform _curvas;
    [SerializeField] private TMP_Text _golova;

    private int _Lokko;
    private int _hulkkaa;
    private Vector2 _asfkkk;
    public BoxCollider2D Jksda => _rurur.Hllop;

    private Korzinochkin _korka;

    private void Start()
    {
        _golova.text = _hulkkaa.ToString();
        PlayerPrefs.SetInt("kjjs", _hulkkaa);
        _asfkkk = new Vector2(Jksda.size.x * _curvas.localScale.x, Jksda.size.y * _curvas.localScale.y);
        
        var huj = _asfkkk.x;
        _Lokko = (int)(huj / _ukaShir);
        
        PrivetZlo();
    }

    private void PrivetZlo()
    {
        var kisho = Random.Range(0, _Lokko);
        var achu = new Vector2(0, Jksda.transform.position.y + _chutka);
        var surtuk = -(_asfkkk.x / 2f);
        for (int i = 0; i < _Lokko; i++)
        {
            achu.x = surtuk + (_ukaShir / 2f) + (_ukaShir * i) + _mikaShir;
            if (i != kisho)
                continue;

            _korka = Instantiate(_korzinochkin, achu, Quaternion.Euler(0,0, Random.Range(-45, 46)));
            break;
        }

        _korka.Scorchilsa += OnShmork;
    }

    private void OnShmork()
    {
        _hulkkaa++;
        _korka.Scorchilsa -= OnShmork;
        PrivetZlo();

        _golova.text = _hulkkaa.ToString();
        PlayerPrefs.SetInt("kjjs", _hulkkaa);
    }
}