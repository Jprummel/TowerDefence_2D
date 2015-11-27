using UnityEngine;
using System.Collections;

public class TutorialVideo : MonoBehaviour {
    public MovieTexture tutTexture;
	// Use this for initialization
	void Start () {
        GetComponent<Renderer>().material.mainTexture = tutTexture;
        tutTexture.Play();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
