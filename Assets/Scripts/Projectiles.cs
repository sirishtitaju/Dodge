using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectiles : MonoBehaviour {
	public float speed;
	public Transform player;
	public Transform targetPoint;
	private Vector2 target;
	public GameObject deadParticle;
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player").transform;
		// float tempX = Random.Range(0.1f,-0.1f);
		target = new Vector2(player.position.x, player.position.y);
	}	
	// Update is called once per frame
	void Update () {
		Vector3 difference = player.position - transform.position;
 		float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg - 90f;
 		transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);

	//	Rigidbody2D rb = GetComponent<Rigidbody2D>();
	//	rb.AddForce(targetPoint.up * 20f, ForceMode2D.Impulse);
		// transform.position = Vector2.MoveTowards(transform.position, target, speed*Time.deltaTime);
		// if(transform.position.x == target.x && transform.position.y == target.y)
		// {
		// 	Destroy(gameObject);
		// 	//destroy partice effect 
		// 	//Instantiate(deadParticle,transform.position,Quaternion.identity);
		// }
	}
	 void OnTriggerEnter2D(Collider2D target) {
		if(target.tag == "Player")
		{
			Debug.Log("Hit Player");
			Destroy(gameObject);
		}
		if(target.tag == "Enemy")
		{
			Debug.Log("Hit Enemy");
			Destroy(target.gameObject);
		}
	}
}
