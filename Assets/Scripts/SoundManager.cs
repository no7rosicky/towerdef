using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

	public AudioClip soundExplosion;
	public AudioClip soundShoot;
	public AudioClip soundDeath;
	AudioSource myAudio;

	public static SoundManager soundInstance;

	void Awake ()
	{
		if(SoundManager.soundInstance == null)
			SoundManager.soundInstance = this;
	}

	// Use this for initialization
	void Start () {
		myAudio = GetComponent<AudioSource>();
	}

	public void SoundExp()
	{
		myAudio.PlayOneShot(soundExplosion);
	}

	public void SoundSht()
	{
		myAudio.PlayOneShot(soundShoot);
	}
	public void SoundLifedown()
	{
		myAudio.PlayOneShot(soundDeath);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
