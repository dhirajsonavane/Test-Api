# Test-Api
A sample Web Api project with decoupled architecture which returns Traffic Monitoring data

## Technologies Used
#### Development
1. .Net Core 3.1
2. Entity Framework Core
3. Autofac
4. Automapper
5. nLog
6. XUnit
7. Moq

## Steps to run on your machine
1. Install .Net Core Cli > 3.1 on your machine
2. Install efcore cli tools using below commands

   dotnet tool install --global dotnet-ef
   dotnet add package Microsoft.EntityFrameworkCore.Design

3. In your terminal window type below command

#### git clone https://github.com/dhirajsonavane/Test-Api.git

4. Open Test.Api.sln in visual studio and update database connection strings in 
  - Test.Api -> Test.Api -> appsettings.Development.json
  - Test.Infrastructure -> appsettings.json
  
5. Now, in your terminal window, cd into Test.Infrastructure project and type below command to create and seed database.

#### dotnet ef database update

6. In your visual studio, run the api using f5 key. It should open https://localhost:5001/swagger/index.html in your browser
7. Expand Monitoring tab, click Try Out button and enter Api Key. You can find it inside Test.Api -> Test.Api -> appsettings.Development.json
8. Click on Execute
9. It should show you returned json data
