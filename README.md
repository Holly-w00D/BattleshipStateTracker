# BattleshipStateTracker

# The Task 

The task is to implement a Battleship state-tracker for a single player that must support the following logic: 

● Create a board  

● Add a battleship to the board 

● Take an “attack” at a given position, and report back whether the attack resulted in a hit or a miss. 

Application should not implement the entire game, just the state tracker. No UI or persistence layer is required. 

# Deployment 

The application has been deployed using Azure and can be viewed here: https://battleshipstatetracker.azurewebsites.net/

# Dependencies
● [.NET Core 5.0](https://www.microsoft.com/net/download)

# How To Install Locally

● Ensure you've installed .NET Core 5

● Open the command prompt

● Ensure you have git installed

● Run the following git clone: ```git clone git@github.com:cameronfathers/BattleshipStateTracker.git```

● Click the .sln to open the project with Visual Studio


# Unit Testing

``xUnit:`` In Visual Studio, go to Test > Run > All Tests

# How To Run With Command

● Type ```dotnet restore``` in the command prompt

● Type ```dotnet build``` in the command prompt

● Type ```dotnet run``` inside the BattleShipStateTracker project

● Type ```dotnet test``` inside the Battleship.Tests project

# How To Use

Create a board.

``Local URL:`` https://localhost:5001/api/battle/create

``Public URL:`` https://battleshipstatetracker.azurewebsites.net/api/battle/create
```
{
  "rows": 10,
  "columns": 10
}
```

Add a battleship to the board.

``Local URL:`` https://localhost:5001/api/battle/place

``Public URL:`` https://battleshipstatetracker.azurewebsites.net/api/battle/place
```
{
  "boardRows": 10,
  "boardColumns": 10,
  "placementRow": 0,
  "placementColumn": 0,
  "shipType": 4
}
```
Take an "attack", expecting a hit.

``Local URL:`` https://localhost:5001/api/battle/attack

``Public URL:`` https://battleshipstatetracker.azurewebsites.net/api/battle/attack

```
{
	"boardRows": 10,
	"boardColumns": 10,
	"placementRow": 0, 
	"placementColumn": 0,
	"attackRow": 0, 
	"attackColumn": 0, 
	"shipType": 1,
	"boardCellStatus": 2
}
```
