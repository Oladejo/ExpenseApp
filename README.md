# Expense App
A simple web-app backend API to handle Personnel Expenses

Goal
---------
Produce a simple web-app backend API to complement an unknown 
frontend code that may be written in any front end library (vue/angular/react).

Description
---------------
The APP is built using .Net Core 3.0, MSSQL Server and Visual Studio 2019.
This app is build using Code First Approach

Instruction
-------------
1. Create an new ASP.Net Core Web API Application
2. Go to Nuget Package Manager to install to following package <br>
   a. Microsoft.EntityFrameworkCore.SqlServer v3.1.1 <br>
   b. Swashbuckle.AspNetCore v5.0 <br>
3. Add folders with the following names to the project <br>
  a. DTO <br>
  b. Entities <br>
  c. Services
4. Creat a model class called Expense and Expense Context inside Entities
5. Create ExpenseDTO, ResponseMessage and VATSetting inside DTO folder
6. Add ExpenseService and ExpenseService interface inside Services folder
7. Add Database connection to AppSettings.json
8. Go to Start.cs to add database connection and VAT percentage value
9. Go to Package Manager Console to run migration and update the database <br>
	Add-Migration MigrationName <br>
	Update-database <br>
10. Create a controller to handle create and get expense
11. Press F5 or Ctrl + F5 to run the APP
