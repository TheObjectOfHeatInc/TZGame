using TMPro;
using UnityEditor.DeviceSimulation;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private TextMeshProUGUI scoreText;
    private static int score = 0;

    public static int inc = 300;

    private void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();

    }
    // Как сделать так, чтобы обновление происходило по требованию а не каждый тик?
    private void Update()
    {
        scoreText.text = $"TEST SCORE : {score}$";
    }
    public static void IncScore()
    {
        score += inc;
    }

}
