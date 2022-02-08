using UnityEngine;
using System.Collections;
using MidiJack;

public class DeviceNoteBoxScript : MonoBehaviour {

	public int noteId;
	public uint deviceId;

	// Use this for initialization
	void Start () {
		
		// setting delegates so functions get called
		MidiMaster.noteOnDelegate += NoteOn;
		MidiMaster.noteOffDelegate += NoteOff;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void NoteOn(uint source, MidiChannel channel, int note, float velocity)
	{
		if (noteId == note && source == deviceId) {
			gameObject.GetComponent<Renderer>().enabled = false;
			Debug.Log("deviceId: " + source);
		}
	}

	void NoteOff(uint source, MidiChannel channel, int note)
	{
		if (noteId == note && source == deviceId) {
			gameObject.GetComponent<Renderer>().enabled = true;
			Debug.Log("deviceId: " + source);
		}
	}

	void OnDestroy()
	{
		MidiMaster.noteOnDelegate -= NoteOn;
		MidiMaster.noteOffDelegate -= NoteOff;
	}
}
