using Task2;

static double SumOfCircleAreas(Shape[] shapes)
{
	double sum = 0;
	for (int i = 0; i < shapes.Length; i++)
	{
		if (shapes[i] is Circle)
		{
			sum += shapes[i].CalculateArea();
		}
	}
	return sum;
}

static int CountSquare(Shape[] shapes)
{
	int count = 0;
	Rectangle rectangle= new Rectangle();
	for (int i = 0; i < shapes.Length; i++)
	{
		if (shapes[i] is Rectangle)
		{
			rectangle = (Rectangle)shapes[i];
			if (rectangle.Height == rectangle.Width)
			{
				count++;
			}
		}
	}
	return count;
}