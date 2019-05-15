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
	private string Value;

	public Fractions frValue
	{
		get
		{
			Fractions frValue = new Fractions(Int32.Parse(Value.Split('/')[0]), Int32.Parse(Value.Split('/')[1]));
			return frValue;
		}

		set
		{
			Value = value.numerator.ToString() + "/" + value.denominator.ToString();
		}
	}
}
