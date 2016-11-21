using UnityEngine;
using System.Collections;

public class AnimationController : MonoBehaviour {

	public Animator anim;
	public Rigidbody rb;

	private float inputH;
	private float inputV;

	// Use this for initialization
	void Start () {

		anim = GetComponent<Animator> ();
		rb = GetComponent<Rigidbody> ();
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown("up")) 
		{
			anim.Play ("Walk", -1, 0.2f);
		}
	
		if (Input.GetKeyDown("space")) 
		{
			anim.Play ("Jump", -1, 0f);
		}


		inputH = Input.GetAxis ("Horizontal");
		inputV = Input.GetAxis ("Vertical");

		anim.SetFloat("inputH", inputH);
		anim.SetFloat("inputV", inputV);

		float moveX = inputH * 20f * Time.deltaTime;
		float moveZ = inputV * 50f * Time.deltaTime;

		rb.velocity = new Vector3 (moveX, 0f, moveZ);

			
	}
			
}
