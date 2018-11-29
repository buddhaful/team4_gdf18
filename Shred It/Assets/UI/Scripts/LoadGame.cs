 using UnityEngine;
 using System.Collections;
 using UnityEngine.SceneManagement;
 
 public class LoadGame : MonoBehaviour 
 {
     public void SceneSwitcher() {
         SceneManager.LoadScene (2);
     }
 }