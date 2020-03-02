using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject ball;

	public float smoothSpeed = 0.125f;
	public Vector3 offset;
	// Use this for initialization
	void Start () {
		//offset = transform.position - ball.transform.position;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Vector3 desiredPosition = ball.transform.position + offset;
		Vector3 smoothPos = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
		transform.position = smoothPos;

		transform.LookAt(ball.transform);
	}
}
