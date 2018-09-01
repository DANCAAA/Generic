using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]

public class ClickSound : MonoBehaviour {

    public AudioClip clicksound;
    private Button Genericbutton { get { return GetComponent <Button>();}}
    private AudioSource audiosource { get { return GetComponent<AudioSource>();}}

    // Use this for initialization
    void Start ()
    {
		gameObject.AddComponent<AudioSource>();
        audiosource.clip = clicksound;
        audiosource.playOnAwake = false;
        Genericbutton.onClick.AddListener( () => playSound() );
    }
	
	// Update is called once per frame
	void playSound()
    {
        audiosource.PlayOneShot(clicksound);
    }
}
