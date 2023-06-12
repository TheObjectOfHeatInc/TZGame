using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerByID : MonoBehaviour
{
    private void Awake()
    {
        
    }
    public static void LoadingScreenByID(SceneID sceneID)
    {
        string sceneName = sceneID.ToString();
        SceneManager.LoadScene(sceneName);

    }

    public enum SceneID { GameScene, IntoScene }
}
