using _24._01;


static int ElectroCarsCount(Car[] cars)
{
	int count = 0;
	
	for (int i = 0; i < cars.Length; i++)
	{
		if (cars[i] is ElectroCar)
		{
			count++;
		}
	}
	return count;
}