using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Praise : MonoBehaviour {
	
	public float num;
	public GameObject trigger;
	public AudioSource audioClip;
	
	void OnTriggerEnter2D (Collider2D collider)
	{
		if(collider.tag == "Praise")
		{
			trigger.SetActive(true);
			audioClip.Play();
		}
	}
}
