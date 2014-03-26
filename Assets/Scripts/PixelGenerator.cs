using UnityEngine;
using System.Collections;

public class PixelGenerator : MonoBehaviour {

	public GameObject prefab;
	public GameObject pixel1;
	public GameObject pixel2;

	// Use this for initialization
	void Start () {
		//mario size is 12x16
		int columns = 12;
		int rows = 16;

		Vector3 pos1 = pixel1.transform.position;
		Vector3 pos2 = pixel2.transform.position;

		float width = (pos2.x - pos1.x)/(columns-1);
		float height = (pos2.y - pos1.y)/(rows-1);

		Vector3 currentPosition;

		for(int column = 1; column <= columns; column++)
		{
			for(int row = 1; row <= rows; row++)
			{
				currentPosition = pos1 + new Vector3((column-1)*width,
				                                 (row-1)*height,
				                                 0f);
				Instantiate(prefab, currentPosition, prefab.transform.rotation);
			}
		}

	}
}
