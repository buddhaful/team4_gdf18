 using UnityEngine;
 using System.Collections;
 using UnityEngine.SceneManagement;
 
 public class LoadSettings : MonoBehaviour 
 {
     public void SceneSwitcher() {
         SceneManager.LoadScene (2);
     }
 }