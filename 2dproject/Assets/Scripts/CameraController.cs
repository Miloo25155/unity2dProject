using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public float timeToFollow = 0.2f;

	public Vector2 zoomMinMax;

	public Player player;
	public Vector3 offset;

	Vector3 velocitySmoothing;


	// Update is called once per frame
	void FixedUpdate () {
		Vector3 desiredPosition = player.transform.position + offset;
		Vector3 smoothedPosition = Vector3.SmoothDamp (transform.position, desiredPosition, ref velocitySmoothing, timeToFollow);
		transform.position = smoothedPosition;
	}
}
