using UnityEngine;
using UnityEngine.UI;

public class Check : MonoBehaviour 
{
	[Tooltip ("Text object showing user's input")]
	public Text usersInputText;

	[Header("States")]
	public StateData correctAnswersNum;
	public NonRangedStateData wrongAnswersNum;
	public NonRangedStateData correctAnswer;

	int typedDigit;
	Fractions typedFraction;
	FractionsViewer fractionViewer;
	Fractions fractionCorrectAnswer;

	public void CheckResult () 
	{
		if (IsThisFractionExample())
		{
			fractionViewer = this.GetComponent<PressButton>().userInputFractionObj.GetComponent<FractionsViewer>();
			//getting user inputed fraction from Text objects
			typedFraction = new Fractions(int.Parse(fractionViewer.Numerator.text), int.Parse(fractionViewer.Denominator.text));

			if (IsCorrectAnswer())
				correctAnswersNum.ApplyChange(1);
			else
				wrongAnswersNum.ApplyChange(1);

			//reset user's input
			typedFraction = new Fractions(0,1); 
		}
		else
		{
			//getting user's inputed digit from Text object
			typedDigit = int.Parse(usersInputText.text);

			if (IsCorrectAnswer())
				correctAnswersNum.ApplyChange(1);
			else
				wrongAnswersNum.ApplyChange(1);

			//reset user's input
			typedDigit = -1;
		}
	}


	bool IsCorrectAnswer()
	{
		if (IsThisFractionExample())
		{
			fractionCorrectAnswer = this.GetComponent<ExampleGenerator>().fractionCorrectAnswer.frValue;
			return fractionCorrectAnswer == typedFraction;
		}
		else
		{
			return correctAnswer.Value == typedDigit;
		}
	}


	bool IsThisFractionExample()
	{
		return (this.GetComponent<ExampleGenerator>().exampleSwitch.Value == 3);
	}
}
