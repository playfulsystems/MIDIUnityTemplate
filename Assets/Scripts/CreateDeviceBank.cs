using UnityEngine;
using System.Collections;

public class CreateDeviceBank : MonoBehaviour {

	public GameObject noteBoxPrefab;
	public uint deviceId;

	// Use this for initialization
	void Start () {

		float xPos = -13f * 0.25f;
		for(int i=48;i<73;i++) {
			xPos += 0.25f;
			GameObject newNoteBox = Instantiate(noteBoxPrefab);
			newNoteBox.GetComponent<DeviceNoteBoxScript>().noteId = i;
			newNoteBox.GetComponent<DeviceNoteBoxScript>().deviceId = deviceId;
			newNoteBox.transform.position = new Vector2(xPos, transform.position.y);
		}

	}
	
	// Update is called once per frame
	void Update () {

	
	}

}
