using UnityEngine;

public class EnableButtons : MonoBehaviour
{
    [SerializeField] int controllerNext;
    PlayerInput input;
    [SerializeField] GameObject interactCanvas;
    bool canInteract=false;
    void Start()
    {
        input = FindObjectOfType<PlayerInput>();
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player" && controllerNext==0)
        {
            FindObjectOfType<GameMaster>().controllerLevel=controllerNext;
            Destroy(gameObject);
        } 
        else if(other.gameObject.tag == "Player")
        {
            canInteract=true;
            interactCanvas.SetActive(true);
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            canInteract = false;
            interactCanvas.SetActive(false);
        }
    }

    void Update()
    {
        if(canInteract && input.inputActions.PlayerControls.Interact.triggered)
        {
            FindObjectOfType<GameMaster>().controllerLevel=controllerNext;
            Destroy(gameObject);
        }
    }
}
