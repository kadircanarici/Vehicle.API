# Vehicle.API
A web API project (.NET Core)

The user should have access to a repository of cars, boats, and buses with different colors (red, blue, black, white). 

The car should be a vehicle (base class). 

A vehicle can have a color and buses and boats can be a vehicle. 

The car should have wheels and headlights. 


Make the below API to access:

• [GET] User should be able to select cars by color.

• [GET] User should be able to select all cars.

• [GET] User should be able to select buses by color.

• [GET] User should be able to select all buses.

• [GET] User should be able to select boats by color.

• [GET] User should be able to select all buses.

• [POST] User should be able to turn on/off headlights of the car by car’s ID.

• [DELETE] User should be able to delete the car. 


The code that selects the vehicles and returns it should be in a separate class (scoped service) and should be accessed by the controller using dependency injection. 
