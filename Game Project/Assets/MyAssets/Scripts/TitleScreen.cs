using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleScreen : MonoBehaviour {
	
	//public string resetintro;
	public Image blackfade;
	public Image white;
	public Image characterface;



	IEnumerator Start () 
	{
		blackfade.canvasRenderer.SetAlpha (1.0f);
		characterface.canvasRenderer.SetAlpha (0.0f);
		white.canvasRenderer.SetAlpha (0.0f);
		yield return new WaitForSeconds(0.3f);
		whiteflash ();
		yield return new WaitForSeconds(0.2f);
		whiteoutflash ();
		yield return new WaitForSeconds(0.3f);
		whiteflash ();
		yield return new WaitForSeconds(0.2f);
		whiteoutflash ();
		yield return new WaitForSeconds(0.4f);
		whiteflash ();
		yield return new WaitForSeconds(0.2f);
		whiteoutflash ();
		Destroy (white);
		yield return new WaitForSeconds(1.5f);

//fade in character 
		Fadeinface ();
		yield return new WaitForSeconds(1.5f);
//blackfade
		Fadeoutblack();
		yield return new WaitForSeconds(0.5f);
		Destroy (blackfade);
	}
//VOIDS
	void Fadeoutblack()
	{
		blackfade.CrossFadeAlpha (0.0f, 1.0f, false);
	}

	void whiteflash()
	{
		white.CrossFadeAlpha (1.0f, 0.5f, true);
	}
	void whiteoutflash()
	{
		white.CrossFadeAlpha (0.0f, 0.3f, false);
	}

	void Fadeinface()
	{
		characterface.CrossFadeAlpha (1.0f, 2.5f, false);
	}

}
