using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    // [SerializeField]
    // public float offset;
    [SerializeField]
    private float leftLimit;
    [SerializeField]
    private float rightLimit;
    [SerializeField]
    private float bottomLimit; 
    [SerializeField]
    private float topLimit; 
    [SerializeField]
    Vector2 posOffset;
    [SerializeField]
    float timeOffset;
    // public BoxCollider2D mapBosunds;

    void Start(){
        player = GameObject.Find("MainCharacter").transform;
        // xMin = mapBounds.bounds.min.x;
        // xMax = mapBounds.bounds.max.x;
        // yMin = mapBounds.bounds.min.y;
        // yMax = mapBounds.bounds.max.y;
        // screenAspect = Screen.width/Screen.height;
        // cameraRatio = screenAspect * camOrthsize;
    }

    void Update(){
        Vector3 startPos = transform.position;
        Vector3 endPos = player.transform.position;
        endPos.x += posOffset.x;
        endPos.y += posOffset.y;
        endPos.z = -10;

        transform.position = Vector3.Lerp(startPos, endPos, timeOffset * Time.deltaTime);

        transform.position = new Vector3
        (
            Mathf.Clamp(transform.position.x, leftLimit, rightLimit),
            Mathf.Clamp(transform.position.y, bottomLimit, topLimit),
            transform.position.z
        );
            
    }
    // private void Update(){
    //         camY = Mathf.Clamp(transform.position.y, camOrthsize, yMax-camOrthsize);
    //         camX = Mathf.Clamp(transform.position.x, cameraRatio, xMax-cameraRatio);
    //         this.transform.position = new Vector3(camX, camY, this.transform.position.z);
    // }
    // private void FixedUpdate(){

    // }
    // void LateUpdate(){
    //     Vector3 temp = transform.position;
    //     temp.x = Mathf.Clamp(player.position.x, xMin, xMax);
    //     temp.x += offset;
    //     transform.position = temp;
    // }
}