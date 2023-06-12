using UnityEngine;
using UnityEngine.UI;

public class StoreBtn : MonoBehaviour
{
    [SerializeField] private Button introBtn;


    private void Awake()
    {
        introBtn = GetComponent<Button>();
        introBtn.tag = "Interface";
    }
}
