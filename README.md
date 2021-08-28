# Exam .NET Core

This webproject runs over ASPNET Core with EntityFrameworkCore

## Requeriments

* Visual Studio 2019
* IIS Express
* SQL Server 

## Connection strings

Feel free to use another sql connection string

```
Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=DBExam;Integrated Security=True;Pooling=False
```

## Instructions

1. Run the script from "ScriptBD.sql" in SQL Server.
2. Make sure that script has been executed correctly
3. Open solution (.sln) with Visual Studio
4. Now run the proyect using Visual Studio (make sure that WebApi is init project)
5. Testing the service with Postman, import the file 'BackEnd.postman_collection.json'
6. If the port is different that '31211', please change in the postman request.