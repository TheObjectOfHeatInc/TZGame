using UnityEngine;
using UnityEngine.UI;

public class StoreBtn : MonoBehaviour
{
    [SerializeField] private Button shopBtn;
    [SerializeField] private GameObject Shop;
    [SerializeField] private GameObject touchSystem;


    private void Awake()
    {
        shopBtn = GetComponent<Button>();
        shopBtn.tag = "Interface";

        void SetShopActive() {
            Shop.SetActive(!Shop.active);
            touchSystem.SetActive(!touchSystem.active);
        }

        shopBtn.onClick.AddListener(SetShopActive);

    }
}
