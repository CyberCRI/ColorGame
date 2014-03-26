using UnityEngine;
using System.Collections;

public class ImageInitializer : MonoBehaviour {

	public SpriteRenderer image;

	// Use this for initialization
	void Start () {
		image.transform.localScale = new Vector3(40f, 40f, 1f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
