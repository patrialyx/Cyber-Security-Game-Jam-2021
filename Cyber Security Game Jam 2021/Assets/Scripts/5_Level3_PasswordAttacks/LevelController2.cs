using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController2 : MonoBehaviour
{
    [SerializeField] private GameObject SuccessMessage;
    [SerializeField] private GameObject FailureMessage;
    [SerializeField] private GameObject FlyingBrownie;

    float distanceFromCamera = 10f;

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Key (4)") == null)
        {
            Debug.Log("Password successfully hacked!");
            //Destroy(GameObject.Find("FlyingBrownie"));
            FlyingBrownie.SetActive(false);

            Vector3 centerPos = Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, distanceFromCamera));
            SuccessMessage.transform.position = centerPos;
            SuccessMessage.SetActive(true);

            return;
        }
        if (GameObject.Find("Key") == null ||
              GameObject.Find("Key (1)") == null ||
              GameObject.Find("Key (2)") == null ||
              GameObject.Find("Key (3)") == null)
        {
            Debug.Log("Hacking of password failed!");
            //Destroy(GameObject.Find("FlyingBrownie"));
            FlyingBrownie.SetActive(false);

            Vector3 centerPos = Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, distanceFromCamera));
            FailureMessage.transform.position = centerPos;
            FailureMessage.SetActive(true);

            return;
        }
    }

    public void tryAgain()
    {
        FlyingBrownie.SetActive(true);
        SceneManager.LoadScene("7_Password_Spraying_2");
    }

    public void nextLevel()
    {
        SceneManager.LoadScene("8_Introduction_dictionary_attack");
    }
}
