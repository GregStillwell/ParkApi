# _Parks Api._

#### By _Greg Stillwell_

#### _An Api for national and state parks_

## Technologies Used

* C#
* .NET 6.0
* Entity Framework Core
* JSON


## Description

ParksApi is an ASP.NET Core web Api that allows users to use a database with national and state parks, users are able to view all the parks in the database and filter their results through pagination as well.    

## Setup Instructions

1. Clone this repo.
2. Open your shell (e.g., Terminal or GitBash) and navigate to this project's directory called "ParksApi/". 
3. Create a file named `appsettings.json`: `$ touch appsettings.json`
4. Within `appsettings.json` add the following code, replacing the `uid` and `pwd` values with your own username and password for MySQL.

    ```json
    {
      "Logging": {
        "LogLevel": {
          "Default": "Information",
          "Microsoft.AspNetCore": "Warning"
        }
      },
      "AllowedHosts": "*",
      "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=parksapi;uid=root;pwd=epicodus;"
      }
    }
    ```
5. Set up the database: `$ dotnet ef database update`
6. Navigate to the project directory: `$ cd ParksApi`
7. Run `$ dotnet watch` in the command line to start the project in development mode with a watcher.
8. Open the browser at :https://localhost:7099/swagger/index.html. If you cannot access localhost:7099 it is likely because you have not configured a .NET developer security certificate for HTTPS. To learn about this, review this lesson: [Redirecting to HTTPS and Issuing a Security Certificate](https://www.learnhowtoprogram.com/c-and-net/basic-web-applications/redirecting-to-https-and-issuing-a-security-certificate).

## Endpoints

Base URL: 
  ```
  https://localhost:7099
  ```

HTTP Request Structure
  ```
  GET /api/Parks
  GET(by id) /api/Parks/{id}
  GET(by state) /api/Parks?state=[name of state]
  POST /api/Parks/{id}
  PUT /api/Parks/{id}
  DELETE /api/Parks/{id}
  ```

Example GET Request
  ```
  https://localhost:7099/api/Parks/1
  ```

Sample Response Body
  ```
 [
  {
    "parkId": 0,
    "name": "string",
    "state": "string"
  }
]
  ```

Search By State Example Request
  ```
  https://localhost:7099/api/Parks?state=washington
  ```

Sample Response Body
  ```
  {
    "parkId": 1,
    "name": "Yellowstone",
    "state": "Washington",

  },
  {
    "parkId": 2,
    "name": "Acadia National Park",
    "state": "Washington",
  }
  ```

  Example POST Request
  ```
  https://localhost:7099/api/Parks

  {
    "name": "Yellowstone ",
    "state": "Texas",
  }
  ```
  * "name" and "state" parameters are required;


  Example PUT Request
  ```
  https://localhost:7099/api/Parks/{id}

  {
    "parkId": 11,
    "name": "The rolls",
    "state": "georgia"
  }
  ```
  * parkId must be declared in the request body for PUT requests

  Example DELETE Request
  ```
  https://localhost:7099/api/Parks/{id}

  {
    "parkId": 72,
    "name": "Acadia National Park",
    "state": "Maine"
  }
  ```
  * parkId must be declared in the request body for DELETE requests too


## Pagination

Users are able to define the number of entries listed per page (page size) and which page they would like to view (page number).

Example
  ```
  https://localhost:7099/api/Parks/paging-filter?pageNumber=1&pageSize=3
  ```

Sample Response Body
  ```
  {
      "parkId": 1,
      "name": "Yellowstone",
      "state": "Wyoming",
  },
  {
      "parkId": 2,
      "name": "Acadia National Park",
      "state": "Maine",
  },
  {
      "parkId": 3,
      "name": "Zion National Park",
      "state": "Utah",
  }
  ```

## Known Bugs



## License
MIT License

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the “Software”), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

Copyright (c) Greg Stillwell 2023 
