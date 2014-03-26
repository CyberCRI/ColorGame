using UnityEngine;
using System.Collections;

public class Cursor : MonoBehaviour {

	//référence vers l'objet pixel
	private InteractivePixel currentPixel;
	public PixelGenerator generator;

	// Use this for initialization
	void Start ()
	{
		currentPixel = generator.getStartPixel();
		transform.position = currentPixel.gameObject.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
		//si on appuie sur "E" le curseur va sur le pixel
		// les modifications de couleur s'appliquent
		//si on réappuie sur "E" le curseur retourne à sa position de départ
		// les modifications de couleur ne s'appliquent pas
		
		if (Input.GetKeyUp(KeyCode.UpArrow))
		{
			currentPixel = currentPixel.top;
			transform.position = currentPixel.gameObject.transform.position;
		}
		if (Input.GetKeyUp(KeyCode.DownArrow))
		{
			currentPixel = currentPixel.bottom;
			transform.position = currentPixel.gameObject.transform.position;
		}
		if (Input.GetKeyUp(KeyCode.LeftArrow))
		{
			currentPixel = currentPixel.left;
			transform.position = currentPixel.gameObject.transform.position;
		}
		if (Input.GetKeyUp(KeyCode.RightArrow))
		{
			currentPixel = currentPixel.right;
			transform.position = currentPixel.gameObject.transform.position;
		}
		
		if(currentPixel != null)
		{
			if (Input.GetKeyUp("t"))
			{
				currentPixel.increaseRed();
			}
			if (Input.GetKeyUp("g"))
			{
				currentPixel.increaseGreen();
			}
			if (Input.GetKeyUp("b"))
			{
				currentPixel.increaseBlue();
			}
			if (Input.GetKeyUp("y"))
			{
				currentPixel.decreaseRed();
			}
			if (Input.GetKeyUp("h"))
			{
				currentPixel.decreaseGreen();
			}
			if (Input.GetKeyUp("n"))
			{
				currentPixel.decreaseBlue();
			}
		}
	}
}
