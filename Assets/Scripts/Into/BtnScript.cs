using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BtnScript : MonoBehaviour
{
    [SerializeField] private Button introBtn;
    [SerializeField] private Scene gameScene;

    private void Awake()
    {
        introBtn = GetComponent<Button>();
        introBtn.tag = "Interface";

        void ChangeScene()
        {
            SceneManagerByID.LoadingScreenByID(SceneManagerByID.SceneID.GameScene);
        }

        introBtn.onClick.AddListener(ChangeScene);

    }
}
