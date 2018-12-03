using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheatKeys : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Alpha1)) {
             SceneManager.LoadScene (3);
         }
		 if (Input.GetKeyDown(KeyCode.Alpha2)) {
             SceneManager.LoadScene (4);
         }
		 if (Input.GetKeyDown(KeyCode.Alpha3)) {
             SceneManager.LoadScene (5);
         }
		 if (Input.GetKeyDown(KeyCode.Alpha4)) {
             SceneManager.LoadScene (6);
         }
		 if (Input.GetKeyDown(KeyCode.Alpha5)) {
             SceneManager.LoadScene (7);
         }
		 if (Input.GetKeyDown(KeyCode.Alpha6)) {
             SceneManager.LoadScene (8);
         }
		 if (Input.GetKeyDown(KeyCode.Alpha7)) {
             SceneManager.LoadScene (9);
         }
		 if (Input.GetKeyDown(KeyCode.Alpha8)) {
             SceneManager.LoadScene (10);
         }
		 if (Input.GetKeyDown(KeyCode.Alpha9)) {
             SceneManager.LoadScene (11);
         }
		 if (Input.GetKeyDown(KeyCode.Alpha0)) {
             SceneManager.LoadScene (12);
         }
	}
}
