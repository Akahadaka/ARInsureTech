using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButtonScript : MonoBehaviour, IVirtualButtonEventHandler {

	public GameObject vbBtnObj;

	void Start()
	{
		vbBtnObj = GameObject.Find("VirtualButton");
		vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
		Debug.Log("BTN Started");
	}

	void Update()
	{
	}

	public void OnButtonPressed(VirtualButtonBehaviour VirtualButtonScript) {

		Debug.Log("BTN Pressed");
	}

	public void OnButtonReleased(VirtualButtonBehaviour VirtualButtonScript) {
		Debug.Log("BTN Released");
	}

	public void test(VirtualButtonBehaviour VirtualButtonScript) {
		Debug.Log("BTN test");
	}
}
