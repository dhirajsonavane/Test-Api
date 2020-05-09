# Test-Api
A sample Web Api project with decoupled architecture

# Steps to run on your machine
1. Install .Net Core Cli > 3.1 on your machine
2. Install efcore cli tools using below command

#### dotnet tool install --global dotnet-ef

2. In your terminal window type below command

#### git clone https://github.com/dhirajsonavane/Test-Api.git

3. Open Test.Api.sln in visual studio and update database connection strings in 
  - Test.Api -> Test.Api -> appsettings.Development.json
  - Test.Infrastructure -> appsettings.json
  
4. Now, in your terminal window, cd into Test.Infrastructure project and type below command to create and seed database.

#### dotnet ef database update

5. In your visual studio, run the api using f5 key. It should open https://localhost:5001/swagger/index.html in your browser
6. Expand Monitoring tab, click Try Out button and enter Api Key. You can find it inside Test.Api -> Test.Api -> appsettings.Development.json
7. Click on Execute
8. It should show you returned json data
