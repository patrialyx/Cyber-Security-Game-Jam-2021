using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorController1 : MonoBehaviour
{
    public GameObject mainDoor;
    public GameObject door;
    public string boolstr;
    public string gatestr;

    [SerializeField]
    private Animator myAnimationController;
    [SerializeField]
    private Animator sphereOpenAnim;
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Player")
        {
            mainDoor.SetActive(true);
            door.SetActive(true);
            myAnimationController.SetBool(gatestr, true);
            sphereOpenAnim.SetBool(boolstr, true);

        }
    }

    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
