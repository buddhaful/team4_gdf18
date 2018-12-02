 using UnityEngine;
 using System.Collections;
 using UnityEngine.SceneManagement;
 
 public class LoadLvl1 : MonoBehaviour 
 {
     public void SceneSwitcher() {
         SceneManager.LoadScene (4);
     }
 }