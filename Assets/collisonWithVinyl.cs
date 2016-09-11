using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class collisonWithVinyl : MonoBehaviour {
    // Use this for initialization
    void Start () {
	
	}

    void OnCollisionEnter(Collision col) {
        if (col.gameObject.name == "Mesh37_Turntable1_Group1_Model") {
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
            audio.Play(44100);
        }

    }
	// Update is called once per frame
	void Update () {
	
	}
}
