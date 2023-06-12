using TMPro;
using Unity.VisualScripting;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

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

        text.transform.localPosition = position;

        text.rectTransform.sizeDelta = new Vector2(800, 150);
        text.color = Color.black;
        text.alignment = TextAlignmentOptions.Center;
        text.overflowMode = TextOverflowModes.Overflow;
        text.fontStyle = FontStyles.Bold;

    }

    private void ProcessCounter()
    {

    }
    private void DestroyCounter() { }
}
