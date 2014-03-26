using UnityEngine;
using System.Collections;

public class TargetImage : MonoBehaviour {

	public int getWidth()
	{
		return (int)gameObject.GetComponent<SpriteRenderer>().sprite.textureRect.width;
	}

	public int getHeight()
	{
		return (int)gameObject.GetComponent<SpriteRenderer>().sprite.textureRect.height;
	}
	
	public int getColumnCount()
	{
		return getWidth ();
	}
	
	public int getRowCount()
	{
		return getHeight();
	}
}
