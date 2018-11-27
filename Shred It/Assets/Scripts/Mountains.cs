 using UnityEngine;
 using System.Collections;
 
 public class Mountains : MonoBehaviour
 {
	private GameManagerScript GMS;
 
	public float speed;
	Vector3 temp;
	
	void Start () {
		GMS = GameObject.Find ("GameManager").GetComponent<GameManagerScript> ();
	}
	void Update()
     {
      
  if (GMS.counterDownDone == true) {  
         temp = transform.localScale;
		 
		 temp.x += Time.deltaTime;
		 temp.y += Time.deltaTime;
		 
		 transform.localScale = temp;
  }
     }
 }