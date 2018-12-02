 using UnityEngine;
 using System.Collections;
 using UnityEngine.SceneManagement;
 
 public class LoadMenu : MonoBehaviour 
 {
     public void SceneSwitcher() {
         SceneManager.LoadScene (1);
     }
 }