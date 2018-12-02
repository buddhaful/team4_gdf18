using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PassLine : MonoBehaviour {
	
	private static int score;
	
	
	 void Update()
     {
         score = PlayerController.count;  //  Update our score continuously.
     }
	 
		void OnTriggerEnter2D (Collider2D other)
 {
	
     if (other.gameObject.tag == "Player" && score == 6) {
         SceneManager.LoadScene (5);
	 }
		 
	if (other.gameObject.tag == "Player" && score < 6) {
		SceneManager.LoadScene (11);
	}
	}
	
}
