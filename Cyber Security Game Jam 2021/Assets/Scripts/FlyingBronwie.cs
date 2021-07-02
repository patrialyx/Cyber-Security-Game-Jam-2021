using UnityEngine;
using UnityEngine.SceneManagement;

public class FlyingBrownie : MonoBehaviour
{
    Vector3 _initialPosition;
    private bool _brownieWasLaunched;
    private float _timeSittingAround;

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
            string currentSceneName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currentSceneName);
        }

    }

    private void OnMouseDown()
    {
        if (_brownieWasLaunched == false)
        {
            GetComponent<SpriteRenderer>().color = Color.red;
            GetComponent<LineRenderer>().enabled = true;
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
