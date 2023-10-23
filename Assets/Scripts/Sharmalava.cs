using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Sharmalava : MonoBehaviour
{
    [SerializeField] private TMP_Text _lawChet;
    [SerializeField] private TMP_Text _VerChet;
    [SerializeField] private Button _nazBut;
    [SerializeField] private Button _nachBut;

    private void Awake()
    {
        var arsh = PlayerPrefs.GetInt("kjjs");
        if (!PlayerPrefs.HasKey("borva"))
            PlayerPrefs.SetInt("borva", arsh);

        var birba = PlayerPrefs.GetInt("borva");

        if (arsh > birba)
        {
            birba = arsh;
            PlayerPrefs.SetInt("borva", birba);
        }

        _lawChet.text = $"YOU SCORE: {arsh}";
        _VerChet.text = $"BEST SCORE: {birba}";
        
        _nazBut.onClick.AddListener(OnNaz);
        _nachBut.onClick.AddListener(OnNach);
    }

    private void OnNaz()
    {
        SceneManager.LoadScene(1);
    }

    private void OnNach()
    {
        SceneManager.LoadScene(0);
    }
}
