using UnityEngine;
using UnityEngine.InputSystem;


public class TouchHandle : MonoBehaviour
{

    private PlayerInput playerInput;
    private InputAction touchPressAction;
    private InputAction touchPositionAction;

    [SerializeField] private GameObject[] ui;

    private void Start()
    {
        ui = GameObject.FindGameObjectsWithTag("Interface");
    }
    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        touchPressAction = playerInput.actions.FindAction("IncScore");
        touchPositionAction = playerInput.actions.FindAction("touchPosition");
    }

    private void OnEnable()
    {
        touchPressAction.performed += TouchPressed;
    }

    private void OnDisable()
    {
        touchPressAction.performed -= TouchPressed;
    }

    private void TouchPressed(InputAction.CallbackContext context)
    {
        ui = GameObject.FindGameObjectsWithTag("Interface");
        bool isUI = false;
        for (int i = 0; i < ui.Length; i++)
        {
            Vector3 objectCoords = ui[i].transform.position;
            RectTransform rt = (RectTransform)ui[i].transform;

            // TODO: Добавить отслеживание положения углов для варианта с поворотм элемента UI

            Vector3[] v = new Vector3[4];
            rt.GetWorldCorners(v);

            //Debug.Log("World Corners");
            //for (var j = 0; j < 4; j++)
            //{
            //    Debug.Log("World Corner " + j + " : " + v[j]);
            //}

            Vector2 touchPosition = touchPositionAction.ReadValue<Vector2>();

   


            if (v[0].x < touchPosition.x && v[2].x > touchPosition.x && v[0].y < touchPosition.y && v[2].y > touchPosition.y)
            {
                isUI = true;
            }

         
               
        }

        if(!isUI) { 
            Score.IncScore();
            Counter.GenerateCounter();
        } 


    }

}
