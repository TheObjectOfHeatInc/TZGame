using TMPro;
using Unity.VisualScripting;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using System;

public class Counter : MonoBehaviour
{
    static private Canvas canvas;
    static private GameObject counter;
    static private TextMeshProUGUI text;

    [SerializeField] static private GameObject coin;

    private void Awake()
    {
        canvas = GetComponent<Canvas>();
        coin = GameObject.Find("Coin");

    }

    static public void GenerateCounter()
    {


        counter = new GameObject
        {
            name = "Counter",
        };

        counter.transform.parent = canvas.transform;
        text = counter.AddComponent<TextMeshProUGUI>();

        text.text = $"THE MASTER GAVE U {Score.inc} BUCKS";

        Vector3 position = coin.transform.position;

        text.transform.position = position;

        text.rectTransform.sizeDelta = new Vector2(800, 150);
        text.color = Color.black;
        text.alignment = TextAlignmentOptions.Center;
        text.overflowMode = TextOverflowModes.Overflow;
        text.fontStyle = FontStyles.Bold;


        ProcessCounter(counter, text);
    }

    static private void ProcessCounter(GameObject counter, TextMeshProUGUI text)
    {
        
        counter.transform.DOBlendableMoveBy(new Vector3(0f, 300f, 0), 1f).OnComplete(() => DestroyCounter(counter));
    }
    static private void DestroyCounter(GameObject counter)
    {
        Color color = Color.white;
        color.a = 0;
        text.DOColor(color, 1.5f).OnComplete(() => Destroy(counter));
    }
}
