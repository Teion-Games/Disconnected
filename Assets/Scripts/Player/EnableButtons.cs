using UnityEngine;

public class EnableButtons : MonoBehaviour
{
    [SerializeField] int controllerNext;
    PlayerInput input;
    [SerializeField] GameObject interactCanvas;
    bool canInteract = false;
    [SerializeField] bool isNewScene;
    void Start()
    {
        input = FindObjectOfType<PlayerInput>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag=="Player" && isNewScene)
        {
            FindObjectOfType<GameMaster>().controllerLevel = controllerNext;
        }
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && controllerNext == 0)
        {
            FindObjectOfType<GameMaster>().controllerLevel = controllerNext;
            Destroy(gameObject);
        }
        else if (other.gameObject.tag == "Player")
        {
            canInteract = true;
            interactCanvas.SetActive(true);
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            canInteract = false;
            interactCanvas.SetActive(false);
        }
    }

    void Update()
    {
        if (canInteract && input.inputActions.PlayerControls.Interact.triggered)
        {
            AudioManager.instance.PlaySound("Activate");
            FindObjectOfType<GameMaster>().controllerLevel = controllerNext;
            Destroy(gameObject);
        }
    }
}
