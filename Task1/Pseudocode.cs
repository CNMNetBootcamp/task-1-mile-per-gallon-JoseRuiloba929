//Create a program that asks the user for the number of miles traveled and the amount of gas used. 
//Calculate the miles per gallon.


//setup
single milesTraveled;
single gallonsUsed;


//input
"What is the ammout in miles that you traveled?";
get milesTraveled;

"What is the amount in gallons did you use for the trip?"
get gallonsUsed;

//process
single MPG = milesTraveled / gallonsUsed;


//output
put "Your Miles per gallon (MPG) is" + MPG+ "for the" + milesTraveled + " miles you travelled";