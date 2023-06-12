using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class BtnGenerator : MonoBehaviour
{

    private static Btn btns;
    private void Awake()
    {
        btns = new Btn();
        btns.Generate(gameObject);
    }


}

// Класс отвечает за генерацию кнопки
class Btn
{
    private GameObject buttonObject;
    private Button button;
    private Image buttonImage;

    private GameObject textObject;
    private TextMeshProUGUI text;

    public readonly string btnName;
    public readonly int price;

    public Btn(string btnName = "test", int price = 100)
    {
        this.btnName = btnName;
        this.price = price;

    }
    public GameObject Generate(GameObject gameObject)
    {
        buttonObject = new GameObject(btnName);
        buttonObject.transform.SetParent(gameObject.transform, false);
        button = buttonObject.AddComponent<Button>();
        buttonImage = buttonObject.AddComponent<Image>();

        textObject = new GameObject();
        textObject.transform.SetParent(buttonObject.transform, false);
        text = textObject.AddComponent<TextMeshProUGUI>();

        text.text = $"{btnName} {price}";
        text.alignment = TextAlignmentOptions.Center;
        text.autoSizeTextContainer = true;
        text.fontSize = 78f;
        
        text.overflowMode = TextOverflowModes.Overflow;
        text.fontStyle = FontStyles.Bold;
        text.rectTransform.sizeDelta = new Vector2(800, 150);
        text.color = Color.black;
        

        buttonObject.SetActive(true);  

        button.onClick.AddListener(() => Score.updateInc(price));

        return buttonObject;
    }
}

// Класс отвечает за внутреннюю логику компонента
 class BtnLogic : MonoBehaviour
{
   
}