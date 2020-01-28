using UnityEngine;
using System.Collections;
using MidiJack;

public class NoteBoxScript : MonoBehaviour {

	public int noteId;

	// Use this for initialization
	void Start () {
		
		// setting delegates so functions get called
		MidiMaster.noteOnDelegate += NoteOn;
		MidiMaster.noteOffDelegate += NoteOff;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void NoteOn(MidiChannel channel, int note, float velocity)
	{
		if (noteId == note) {
			gameObject.GetComponent<Renderer>().enabled = false;
		}
	}

	void NoteOff(MidiChannel channel, int note)
	{
		if (noteId == note) {
			gameObject.GetComponent<Renderer>().enabled = true;
		}
	}
}
