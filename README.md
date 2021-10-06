[![Language][language-shield]][language-url]
[![Language][languageH-shield]][languageH-url]
[![MIT License][license-shield]][license-url]

# Best Restaurant

#### This is a C# web application using MySQL databases to collect restaurants and their associated cuisines.

#### _By Paige Tiedeman & Nick Hennessy_

## Technologies Used

* C#
* .NET 5.0
* ASP.NET Core MVC
* MSTest
* HTML 
* Bootstrap
* MySQL Workbench

## Description

A website where users can add their favorite restaurants based on the type of cuisine they offer. 

## Installation Requirements

* _Clone or download the zip file of this repository to your desktop_
* _Navigate into the top level directory_
* _Open in your code editor_
* _Commit and push your .gitignore file to your repo_
* _Add the file BestRestaurant/appsettings.json and insert the following:_
```
{
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=best_restaurant;uid=root;pwd=[YOUR-PASSWORD-HERE];"
    }
}
```
* _Insert your MySQL password_
* _Make sure to have .NET 5.0 installed_
* _Run `$ dotnet restore` to install bin & obj folders_
* _Run `$ dotnet test` in the test folder to see the passed tests_


## Steps To Use
* _Launch MySQL Workbench and select "Create new SQL tab for executing queries"_
* _Enter in the below into the query window and click 'execute'_
```  
CREATE DATABASE IF NOT EXISTS best_restaurant;  
USE best_restaurant;  
DROP TABLE IF EXISTS `restaurants`;  
CREATE TABLE `restaurants` (  
  `RestaurantId` int NOT NULL AUTO_INCREMENT,  
  `Name` varchar(255) DEFAULT NULL,  
  `CuisineId` int DEFAULT '0',  
  PRIMARY KEY (`RestaurantId`)  
);   
DROP TABLE IF EXISTS `cuisines`;  
CREATE TABLE `cuisines` (  
  `CuisineId` int NOT NULL AUTO_INCREMENT,  
  `Type` varchar(255) DEFAULT NULL,  
  PRIMARY KEY (`CuisineId`)  
);  
```
* _In your terminal navigate into BestRestaurant.Solution/BestRestaurant_
* _Run `$ dotnet build` to build the site_
* _Run `$ dotnet run` to start the live server_
* _Click either button to see all restaurants or cuisines_
* _After clicking add restaurant or cuisine put in your inputs and hit submit to reveal the list!_

## Known Bugs

* _N/A_

## License

MIT: See Badge at top for Info  
Copyright (c) 2021 Paige Tiedeman and Nick Hennessy  

## Contact Information

_Paige Tiedeman @ github.com/paigetiedeman_  
_Nick Hennessy_  

[license-shield]: https://img.shields.io/badge/License-MIT-blue
[license-url]: https://opensource.org/licenses/MIT
[language-shield]: https://img.shields.io/badge/Language-C%23-red
[language-url]: https://docs.microsoft.com/en-us/dotnet/csharp/
[LanguageH-shield]: https://img.shields.io/badge/Language-HTML-blueviolet
[LanguageH-url]: https://developer.mozilla.org/en-US/docs/Web/HTML