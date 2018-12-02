 using UnityEngine;
 using System.Collections;
 
 public class Trees : MonoBehaviour
 {
	
	 Animator m_Animator;
	
 private GameManagerScript GMS;
	
	void Start () {
		GMS = GameObject.Find ("GameManager").GetComponent<GameManagerScript> ();
		m_Animator = GetComponent<Animator>();
	}
	void Update()
     {
      
 if (GMS.counterDownDone == true) {  
         m_Animator.Play("Trees");
 }
     }
 }