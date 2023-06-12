using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class LogoScript : MonoBehaviour
{
    [SerializeField] private Transform logoScale;
    [SerializeField] private float logoRotateZ = -10f;

    private float scale;

    private readonly Vector3 maxScale = new(65f, 65f, 0f);

    // Update is called once per frame
    void Start()
    {
        logoScale.Rotate(new Vector3(0f, 0f, logoRotateZ));
        logoScale.DOScale(maxScale, 1f).SetLoops(-1, LoopType.Yoyo);
        logoScale.DORotate(new Vector3(0f, 0f, 10f), 1f).SetLoops(-1, LoopType.Yoyo);

    }
}
