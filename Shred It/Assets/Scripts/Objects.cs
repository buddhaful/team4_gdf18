 using UnityEngine;
 using System.Collections;
 
 public class Objects : MonoBehaviour
 {
  
  private GameManagerScript GMS;
	
	public float speed;
	Vector2 temp;
	Vector3 tempPos;
	
	void Start () {
		GMS = GameObject.Find ("GameManager").GetComponent<GameManagerScript> ();
	}
	void Update()
     {
      
      
 if (GMS.counterDownDone == true) {        
   temp = transform.localScale;
   
		 temp.x += speed * Time.deltaTime;
		 temp.y += speed * Time.deltaTime;
		 
		 transform.localScale = temp;
   
		 tempPos = transform.position;
		 
		 tempPos.y += -0.1111111f * speed;
		 
		 transform.position = tempPos;
 }
     }
     
 }