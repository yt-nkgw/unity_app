﻿using UnityEngine;
using System.Collections;

public class AboutUsController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	/*
	 * On Click Web Jump Button
	 */
	public void OnClickWebButton () {
		OpenApplicationManager.OpenAppByURL("http://www.scopic.nl/");
	}

	/*
	 * On Click Facebook Jump Button
	 */
	public void OnClickFacebookButton () {
		OpenApplicationManager.OpenFBPage("scopicvideo");
	}

	/*
	 * On Click Instagram Jump Button
	 */
	public void OnClickInstagramButton () {
		OpenApplicationManager.OpenInsta("scopic_vr");
	}
}
