using System.Collections;
using System.Collections.Generic;

public struct Fractions
{
	public int numerator;
	public int denominator;

	public Fractions (int x, int y)
	{
		numerator = x;
		denominator = y;
	}

	public static Fractions operator + (Fractions fr1, Fractions fr2)
	{
		Fractions result = new Fractions();
		if (fr1.denominator == fr2.denominator)
		{
			result.numerator = fr1.numerator + fr2.numerator;
			result.denominator = fr1.denominator;
		}
		else
		{
			result.numerator = fr1.numerator * fr2.denominator + fr2.numerator * fr1.denominator;
			result.denominator = fr1.denominator * fr2.denominator;
		}
		
		return result;
	}
}
