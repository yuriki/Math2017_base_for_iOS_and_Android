using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Yuriki's ScriptableObj assets/States/Fractions", fileName = "Fractions")]
public class FractionStateDate : ScriptableObject
{
	#if UNITY_EDITOR
		[Multiline]
		public string DeveloperDescription = "";
#endif
	[SerializeField]
	private string value;
	//private Fractions frValue;

	public Fractions frValue
	{
		get
		{
			Fractions frValue = new Fractions(Int32.Parse(value.Split('/')[0]), Int32.Parse(value.Split('/')[1]));
			return frValue;
		}
	}
}
