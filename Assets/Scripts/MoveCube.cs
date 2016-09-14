using UnityEngine;
using System.Collections;

public class MoveCube : MonoBehaviour {

	private Vector3 movimiento;
	public float velocidad = 5f;
	public Rigidbody rb;
	private bool pequeno = false;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float x = Input.GetAxis("Horizontal");
		float z = Input.GetAxis("Vertical");
		movimiento.Set(x, 0.0f, z);//vector de movimiento
		transform.Translate(movimiento.normalized * velocidad * Time.deltaTime);
		if(!pequeno && transform.position.z >= -1f && transform.position.z <= 1f && transform.position.x >= -9f && transform.position.x <= -7f){
			transform.localScale = new Vector3 (0.5f, 0.5f, 0.5f);
			transform.position = new Vector3 (transform.position.x, 0.25f, transform.position.z);
			pequeno = true;
		}
		if(pequeno && transform.position.z >= -9f && transform.position.z <= -7f && transform.position.x >= 9f && transform.position.x <= 11f){
			transform.localScale = new Vector3 (1f, 1f, 1f);
			transform.position = new Vector3 (transform.position.x, 0.5f, transform.position.z);
			pequeno = false;
		}
		
	}
}