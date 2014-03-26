using UnityEngine;
using System.Collections;

public class ImageInitializer : MonoBehaviour {

	public TargetImage image;

	// Use this for initialization
	void Start () {

		float width = image.getWidth();
		float height = image.getHeight();

		float widthRatio = Screen.width / width;
		float heightRatio = Screen.height / height;

		float finalRatio = Mathf.Min(widthRatio, heightRatio);

		image.transform.localScale = new Vector3(finalRatio, finalRatio, 1f);

		Debug.Log(
			 "width ="        +width
			+", height ="       +height
			+", Screen.width =" +Screen.width
			+", Screen.height =" +Screen.height
			+", widthRatio ="   +widthRatio 
			+", heightRatio ="  +heightRatio
			+", finalRatio ="   +finalRatio 
			);

		image.transform.position = new Vector3(0, 0, 0);
	}
		
	void Update()
	{
		if(Input.GetKeyUp("e"))
		{
			image.gameObject.SetActive(!image.gameObject.activeSelf);
		}
	}
}
