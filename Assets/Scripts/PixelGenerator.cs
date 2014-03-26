using UnityEngine;
using System.Collections;

public class PixelGenerator : MonoBehaviour {

	public GameObject prefab;
	public GameObject pixel1;
	public GameObject pixel2;

	private InteractivePixel[,] pixels;

	public InteractivePixel getStartPixel() {
		if(pixels.Length > 0)
		{
			return pixels[0, 0];
		}
		else
		{
			return null;
		}
	}

	void Awake () {

		//mario size is 12x16
		int columns = 12;
		int rows = 16;

		pixels = new InteractivePixel[rows, columns];

		Vector3 pos1 = pixel1.transform.position;
		Vector3 pos2 = pixel2.transform.position;

		float width = (pos2.x - pos1.x)/(columns-1);
		float height = (pos2.y - pos1.y)/(rows-1);

		Vector3 currentPosition;

		for(int column = 0; column < columns; column++)
		{
			for(int row = 0; row < rows; row++)
			{
				currentPosition = pos1 + new Vector3(column*width,
				                                 row*height,
				                                 0f);
				GameObject newPixel = Instantiate(prefab, currentPosition, prefab.transform.rotation) as GameObject;
				InteractivePixel newInteractivePixel = newPixel.GetComponent<InteractivePixel>();
				pixels[row,column] = newInteractivePixel;
			}
		}
		
		
		for(int column = 0; column < columns; column++)
		{
			for(int row = 0; row < rows; row++)
			{
				if(row < rows-1) {
					pixels[row,column].top = pixels[row+1,column];
				} else {
					pixels[row,column].top = pixels[row,column];
				}

				if(row > 0) {
					pixels[row,column].bottom = pixels[row-1,column];
				} else {
					pixels[row,column].bottom = pixels[row,column];
				}

				if(column > 0) {
					pixels[row,column].left = pixels[row,column-1];
				} else {
					pixels[row,column].left = pixels[row,column];
				}

				if(column < columns-1) {
					pixels[row,column].right = pixels[row,column+1];
				} else {
					pixels[row,column].right = pixels[row,column];
				}
			}
		}
	}


}
