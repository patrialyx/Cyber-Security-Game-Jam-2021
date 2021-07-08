using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takeLive : MonoBehaviour
{
    // Start is called before the first frame update
    public void MinusStuff()
    {
        knowledgeManager.instance.minusLife();
    }
}
