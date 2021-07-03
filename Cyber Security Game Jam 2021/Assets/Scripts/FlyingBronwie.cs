using UnityEngine;
using UnityEngine.SceneManagement;

public class FlyingBrownie : MonoBehaviour
{
    Vector3 _initialPosition;
    private bool _brownieWasLaunched;
    private float _timeSittingAround;
    public GameObject Instruction;
    public GameObject Instruction1;
    [SerializeField] private GameObject FailureMessage;
    float distanceFromCamera = 10f;

    [SerializeField] private float _launchPower = 500;


    private void Awake()
    {
        _initialPosition = transform.position;
    }

    private void Update()
    {
        GetComponent<LineRenderer>().SetPosition(0, transform.position);
        GetComponent<LineRenderer>().SetPosition(1, _initialPosition);

        if (_brownieWasLaunched && 
            GetComponent<Rigidbody2D>().velocity.magnitude <= 0.1)
        {
            _timeSittingAround += Time.deltaTime;
        }

        if (transform.position.y < -10||
            _timeSittingAround > 1.5)
        {
            Vector3 centerPos = Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, distanceFromCamera));
            FailureMessage.transform.position = centerPos;
            FailureMessage.SetActive(true);
        }

    }

    private void OnMouseDown()
    {
        if (_brownieWasLaunched == false)
        {
            GetComponent<SpriteRenderer>().color = Color.red;
            GetComponent<LineRenderer>().enabled = true;
            Instruction = GameObject.Find("Instruction");
            Destroy(this.Instruction);
            Instruction1 = GameObject.Find("Instruction (1)");
            Destroy(this.Instruction1);

        }
    }

    private void OnMouseUp()
    {
        if (_brownieWasLaunched == false)
        {
            GetComponent<SpriteRenderer>().color = Color.white;

            Vector2 directionToInitialPosition = _initialPosition - transform.position;


            GetComponent<Rigidbody2D>().AddForce(directionToInitialPosition * _launchPower);
            GetComponent<Rigidbody2D>().gravityScale = 1;
            _brownieWasLaunched = true;

            GetComponent<LineRenderer>().enabled = false;
        }

    }

    private void OnMouseDrag()
    {
        if (_brownieWasLaunched == false)
        {
            Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            newPosition.x = Mathf.Clamp(newPosition.x, -9, -5);
            newPosition.y = Mathf.Clamp(newPosition.y, 0, 5f);
            transform.position = new Vector3(newPosition.x, newPosition.y);
        }
    }

}
