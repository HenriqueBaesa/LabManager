# Lab Manager


# How to run
- To list all the informations in the database: 
````
$ dotnet run -- Computer List

$ dotnet run -- Laboratory List
````

- To add information to the database:
````
$ dotnet run -- Computer New 1 16 'Intel core I7'

$ dotnet run -- Lab New 1 14 'A'
````
Computer: The parameters are id:'1' ram:'16' and processor:'Intel core I7'.
Lab: The parameters are id:'1' number:'14' and block:'A'.



# How to import
 - Importing the necessary library to use the database:
````
$ dotnet add package Microsoft.Data.Sqlite
$ dotnet add package Dapper
````
