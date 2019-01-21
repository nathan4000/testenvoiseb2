using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playsoundducul : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if (Input.GetKeyDown(KeyCode.B))
        {

            AkSoundEngine.PostEvent("Play_sous_pulls", gameObject);



        }
	}
}
