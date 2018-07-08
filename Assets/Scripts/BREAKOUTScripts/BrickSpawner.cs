using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickSpawner : MonoBehaviour {

	Transform[] ChildrenObj;
	int[] ActiveBricks = new int[10];

	// Use this for initialization
	void Start () {
		ChildrenObj = GetComponentsInChildren<Transform> ();
		foreach (Transform t in ChildrenObj) {
			t.gameObject.GetComponentInChildren<BoxCollider2D> ().isTrigger = true;
			t.gameObject.GetComponentInChildren<SpriteRenderer> ().enabled = false;
		}
		SpawnRandomTiles ();
	}
	
	// Update is called once per frame
	void Update () {
		if (!IsAnyBrickLeft ()) {
			SpawnRandomTiles ();
		}
		
	}

	void SpawnRandomTiles()
	{
		int Length = ChildrenObj.Length;
		for (int i = 0; i < 10; i++) {
			ActiveBricks[i] = Random.Range (0, Length);
			int RandomNum = ActiveBricks [i];
			ChildrenObj [RandomNum].GetComponentInChildren<BoxCollider2D> ().isTrigger = false;
			ChildrenObj [RandomNum].GetComponentInChildren<SpriteRenderer>().enabled = true;
			ChildrenObj [RandomNum].GetComponentInChildren<Animator> ().Play ("Shake");
		}
	}

	bool IsAnyBrickLeft()
	{
		for (int i = 0; i < ActiveBricks.Length; i++) {
			if (ChildrenObj [ActiveBricks [i]].GetComponentInChildren<BoxCollider2D> ().isTrigger == false && ChildrenObj [ActiveBricks [i]].GetComponentInChildren<SpriteRenderer> ().enabled == true) {
				return true;
			}
		}
		return false;
	}
}
