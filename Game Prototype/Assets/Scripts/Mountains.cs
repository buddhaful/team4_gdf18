 using UnityEngine;
 using System.Collections;
 
 public class Mountains : MonoBehaviour
 {
	
	public float speed;
	Vector3 temp;
	
	void Start () {
		
	}
	void Update()
     {
         temp = transform.localScale;
		 
		 temp.x += Time.deltaTime;
		 temp.y += Time.deltaTime;
		 
		 transform.localScale = temp;
 
     }
 }