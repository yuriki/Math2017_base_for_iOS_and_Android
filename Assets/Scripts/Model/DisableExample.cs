using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisableExample : MonoBehaviour
{
	public BoolData currentExampleData;
	public GameObject generalObj;

	private void Awake()
	{
		gameObject.GetComponent<Toggle>().isOn = currentExampleData.toggle;
	}

	public void DisableCurrentExample(bool toggle)
	{
		currentExampleData.toggle = toggle;
		generalObj.GetComponent<LoadCreateSaveLocally>().SaveJSONLocally(currentExampleData.name, currentExampleData);
	}
	
}
