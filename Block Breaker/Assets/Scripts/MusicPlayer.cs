using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {

    static MusicPlayer myMusicPlayer = null;

    void Awake()
    {
        //if myMusicPlayer is the 1st instance
        if (myMusicPlayer == null)
        {
            //myMusicPlayer = 1st SoundObject
            myMusicPlayer = this;
            //this.gameObject = the gameObject attached to this script, in our case SoundObject
            //DonrDestroyOnLoad = do not destroy the gameObject when changing scenes
            GameObject.DontDestroyOnLoad(this.gameObject);
        }
        //if 2nd SoundObject is loaded
        else
        {
            print("Sound object " + this.gameObject.GetInstanceID().ToString());
            //Destroy the 2nd gameObject created
            Destroy(this.gameObject);
        }
    }

    // Use this for initialization
    void Start ()
    {

	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
