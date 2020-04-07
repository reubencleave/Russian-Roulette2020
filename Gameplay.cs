using System;

namespace Russian Roulette
{

	class GamePlay
	{
	int shootaway = 2;
	Boolean CanIshootaway = true;

}
private void ShootAwayCountDown()
{
    //shootaway button
    shootaway--;

    if (shootaway > 0)
    {
        //boolean you can shoot
        CanIshootaway = true;
    }
    else
    {
        //you can't shoot
        CanIshootaway = false;
    }
}
}


}
