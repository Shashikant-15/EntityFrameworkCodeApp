# EntityFrameworkCodeApp

* This repository contains a sample ASP.NET Core application that demonstrates basic CRUD (Create, Read, Update, Delete) operations for managing user data using Entity Framework. Below is an overview of the code structure and its functionality.

## Table of Contents
* **Introduction**
* **Prerequisites**
* **Installation**
* **Usage**
* 
## API Endpoints

* Contributing
## License
## Introduction

The EntityFrameworkCodeApp is an ASP.NET Core application that serves as a RESTful API for managing user information. It provides endpoints to:

## Retrieve a list of users.
* Retrieve a specific user by their ID.
* Add a new user.
* Update an existing user.
* Delete a user by their ID.
  
**** This project uses Entity Framework to interact with the underlying database. It is designed to showcase the basic operations commonly used in web applications.

## Prerequisites
Before running the application, ensure that you have the following prerequisites installed:

* Visual Studio or Visual Studio Code
* .NET SDK
* Entity Framework Core
  ## Installation
To set up and run the application, follow these steps:

**Clone this repository to your local machine.
****Open the project in Visual Studio or Visual Studio Code.
****Make sure you have the necessary NuGet packages installed for Entity Framework and ASP.NET Core.
**Configure the database connection string in the appsettings.json file.
**Run the application.
## Usage
You can test the API using tools like Postman or curl. Below are the available API endpoints:

## API Endpoints
   * GET /api/Users/GetUsers<br>
    Retrieve a list of all users.

* GET /api/Users/GetaUser?id={userId}<br>
Retrieve a specific user by their ID.

* POST /api/Users/AddUser<br>
Add a new user. Send a JSON object with user details in the request body.

* PUT /api/Users/UpdateUser<br>
Update an existing user. Send a JSON object with user details, including the user's ID, in the request body.

* DELETE /api/Users/DeleteUser?id={userId}<br>
Delete a user by their ID.

## Contributing
If you'd like to contribute to this project, please follow these steps:

## Fork the repository.
* Create a new branch for your feature or bug fix.
* Make your changes and commit them with clear and concise messages.
* Push your changes to your forked repository.
* Create a pull request to the original repository.
## License
This project is licensed under the MIT License - see the LICENSE file for details. Feel free to use, modify, and distribute this code according to the terms of the license.

* For any questions or issues, please open a GitHub issue in this repository.
