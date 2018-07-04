using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public IEnumerator ShakeCam(float Duration, float Magnitude)
	{
		Vector3 OriginalPos = transform.localPosition;
		float elapsed = 0f;
		while (elapsed < Duration) {
			float XOffset = Random.Range (-1f, 1f) * Magnitude;
			float YOffset = Random.Range (-1f, 1f) * Magnitude;
			transform.localPosition = new Vector3 (XOffset, YOffset, OriginalPos.z);
			elapsed += Time.deltaTime;
			yield return null;
		}
		transform.localPosition = OriginalPos;
	}
}
