 using UnityEngine;
 
 public class musicContinue : MonoBehaviour
 {
     private void Start()
     {
         GameObject.FindGameObjectWithTag("Music").GetComponent<musicContinueAcrossScenes>().PlayMusic();
     }
 
 }