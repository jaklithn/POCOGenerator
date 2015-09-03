# POCOGenerator
![](Demo.png)

## Background
Often I find myself in situations where I nedd to handle data stored in existing database. To do this I need to create code classes that correspond to this data. Sometimes I use Entity Framework "Code First". Other times I use Dapper. The need is the same. It is boring (and error prone!) to manually copy columns to class properties and set correct data types. That's where this tool fits in. I just point to the database, select a table and the class is generated! In some cases a view or stored procedure is more adequate, so I added that as alternative approach. If you have the same need, feel free to just copy the solution or extend it for your needs.

## Features
- You can use any SQL Server Database.
- The source can be a table, view or stored procedure
- Table names are automatically detected
- Stored procedures can return multiple resultsets
- Resulting class will have properties with identical names and corresponding C# data types
- Class name will be taken from table or view (for procedures you have the possibility to add custom names in a provided "AS" syntax)
- It is easy to add/edit/remove connections to the list
- All settings will be saved during sessions

## Installation
- Download source
- Compile
- All needed code is contained in one single EXE file: POCOGenerator.exe
- Put file wherever you want and run it
- Corresponding settings file will be generated in same directory and can be manually edited



