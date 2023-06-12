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
    private GameObject btnObject;
    private Button btn;

    private GameObject txtObject;
    private TextMeshPro txt;

    public readonly string btnName;
    public readonly int price;

    public Btn(string btnName = "test", int price = 100)
    {
        this.btnName = btnName;
        this.price = price;

    }
    public GameObject Generate(GameObject gameObject)
    {
        btnObject = new GameObject(btnName);
        btnObject.transform.SetParent(gameObject.transform, false);
        btn = btnObject.AddComponent<Button>();

        txtObject = new GameObject();
        txtObject.transform.SetParent(btnObject.transform, false);
        txt = txtObject.AddComponent<TextMeshPro>();

        txt.text = $"{btnName} {price}";
        txt.alignment = TextAlignmentOptions.Center;
        txt.overflowMode = TextOverflowModes.Overflow;
        txt.fontStyle = FontStyles.Bold;
        txt.rectTransform.sizeDelta = new Vector2(800, 150);
        txt.color = Color.black;
        

        btnObject.SetActive(true);  

        btn.onClick.AddListener(() => Score.updateInc(price));

        return btnObject;
    }
}

// Класс отвечает за внутреннюю логику компонента
 class BtnLogic : MonoBehaviour
{
   
}