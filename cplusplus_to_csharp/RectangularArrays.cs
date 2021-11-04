//----------------------------------------------------------------------------------------
//	Copyright © 2006 - 2021 Tangible Software Solutions, Inc.
//	This class can be used by anyone provided that the copyright notice remains intact.
//
//	This class includes methods to convert C++ rectangular arrays (jagged arrays
//	with inner arrays of the same length).
//----------------------------------------------------------------------------------------
internal static class RectangularArrays
{
	public static float[][] RectangularFloatArray(int size1, int size2)
	{
		float[][] newArray = new float[size1][];
		for (int array1 = 0; array1 < size1; array1++)
		{
			newArray[array1] = new float[size2];
		}

		return newArray;
	}

	public static ushort[][] RectangularUshortArray(int size1, int size2)
	{
		ushort[][] newArray = new ushort[size1][];
		for (int array1 = 0; array1 < size1; array1++)
		{
			newArray[array1] = new ushort[size2];
		}

		return newArray;
	}
}