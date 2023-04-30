# CLI Commands REST API (.NET 6)

The Commands API is a RESTful API that allows users to retrieve commonly used CLI commands with a short description of their purpose and which platform they are for. 
Here is the case study link: https://docs.google.com/presentation/d/1Xge_pf_0qEmFBXglHGnD6HHysxI9-KOZ8_991UEcB5g/edit?usp=sharing

## Purpose

This project was created to learn and practice concepts related to building a REST API using .NET Core and the MVC architectural pattern, 
as well as to develop skills in C#. The following tools and technologies were specifically used:

- Dependency injection
- Repository design pattern
- MySQL & MySQL Workbench
- Entity Framework Core O/RM (DBContext, Migration)
- Data Transfer Objects (DTOs) & AutoMapper
- RESTful API guidelines
- HTTP (GET, POST, PUT, PATCH, DELETE, status codes)
- Testing API Endpoints (SwaggerUI)

Please note that the large number of comments in the code are used as notes for later review.

## Architecture and Design

The application architecture and website look are shown below:

![Application Architecture]("C:\Users\joshu\Downloads\MVC Application Architecture.drawio.pdf")

![Website Look](/images/website-look.png)

## API Endpoints

The API endpoints are as follows:

- GET /api/commands - returns a list of all commands
- GET /api/commands/{id} - returns a specific command by its ID
- POST /api/commands - creates a new command
- PUT /api/commands/{id} - updates an existing command by its ID
- PATCH /api/commands/{id} - partially updates an existing command by its ID
- DELETE /api/commands/{id} - deletes an existing command by its ID

