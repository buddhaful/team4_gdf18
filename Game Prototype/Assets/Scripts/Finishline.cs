 using UnityEngine;
 using System.Collections;
 
 public class Finishline : MonoBehaviour
 {
	
	public float speed;
	Vector3 temp;
	Vector3 tempPos;
	
	void Start () {
		
	}
	void Update()
     {
         temp = transform.localScale;
		 
		 temp.x += speed * Time.deltaTime;
		 temp.y += speed * Time.deltaTime;
		 
		 transform.localScale = temp;
		 
		 tempPos = transform.position;
		 
		 tempPos.y += -0.1111111f * speed;
		 
		 transform.position = tempPos;
 
     }
 }