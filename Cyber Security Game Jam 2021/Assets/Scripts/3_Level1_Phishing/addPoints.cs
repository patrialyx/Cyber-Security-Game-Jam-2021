using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addPoints : MonoBehaviour
{
    public void addStuff()
    {
        knowledgeManager.instance.addPoints();
        Debug.Log("added point");
    }
}
