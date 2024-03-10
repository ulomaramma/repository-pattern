# Repository Pattern with Unit of Work Guide for ASP.NET Core Web API

Welcome to the ASP.Net Core Repository Pattern starter project for developers. This project aims to provide a comprehensive starting point for implementing repository patterns with Unit of Work in your projects, enhancing code maintainability, and promoting best practices in software development.

# Give it a Star !!!⭐
If you find this project useful helpful in implementing Repository pattern in your ASP.NET Core project, please give it a star, on GitHub to help others developers discover it! Thanks  


## Table of Contents
1. [Introduction to Repository Pattern and Unit of Work](#introduction-to-repository-pattern-and-unit-of-work)
2. [Getting Started](#getting-started)
   - [Prerequisites](#prerequisites)
   - [Installation](#installation)
3. [Understanding Repository Pattern and Unit of Work](#understanding-repository-pattern-and-unit-of-work)
4. [Configuring Database Connection](#configuring-database-connection)
5. [Contributing](#contributing)
6. [Search Keywords](#search-keywords)

## Introduction to Repository Pattern and Unit of Work

Repository pattern is a popular design pattern used in software development, including C# and .NET applications, especially in the context of domain-driven design and object-relational mapping (ORM). The repository pattern acts as a bridge between the business logic layer and the data access layer of an application by providing an abstraction layer over the data access layer. It allows the business logic to interact with the database without needing to know the underlying data access complexities.


## Getting Started 

### Prerequisites

Before you begin, ensure you have the following installed:
- [.NET SDK](https://dotnet.microsoft.com/download) (Version .Net 6 or later)
- An IDE of your choice (e.g., [Visual Studio](https://visualstudio.microsoft.com/), [VS Code](https://code.visualstudio.com/))
- Basic Understanding of ASP.NET Core Web API concepts. To have a deeper understanding of the Repository Pattern you can read my article [Repository and Unit of Work Patterns in ASP.NET Core: A Key to Cleaner C# Code and Architecture](https://medium.com/@ulomaobilookenyi/repository-pattern-in-asp-net-core-a-key-to-cleaner-c-code-and-architecture-37f76854c9fb)

### Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/ulomaramma/repository-pattern

2. Navigate to the project directory:
   ```bash
   cd repository-pattern

3. Install dependencies:
   ```bash
   dotnet restore

## Understanding Repository Pattern and Unit of Work

The Repository Pattern and Unit of Work are key design patterns used in application development to separate the data access logic and business logic from the rest of the application. This guide implements these patterns using a Generic Repository, which provides a flexible and reusable way to access data across the application.

### Overview of Repository Pattern

![Overview of Repository Pattern](https://github.com/ulomaramma/repository-pattern/assets/26364572/c66489e2-c0f7-4c0c-9acb-10c16824ede6)


*Figure 1: Overview of the Repository Pattern*

The above diagram illustrates the basic structure and components involved in the Repository Pattern. The use of a Generic Repository ensures that common data operations (such as CRUD operations) are abstracted, thereby promoting code reusability and maintainability.

### Project Structure

This guide's project is structured into three main projects to separate concerns and ensure a clean architecture:

- **DataAccess.Core**: Contains the repository and unit of work, alongside db context and migration classes.
- **Domain**: This project houses the domain entities (models) used throughout the application.
- **WebAPI**: The entry point of the application, this project references both the DataAccess.Core and Domain projects to serve data through a RESTful API.

<img width="546" alt="image" src="https://github.com/ulomaramma/repository-pattern/assets/26364572/ca641665-a5af-4b90-94c1-39bd5249aa52">

*Figure 2: Project Structure in Visual Studio*

As depicted in Figure 2, the solution is organized to clearly separate the different aspects of the application, making it easier for developers to navigate and maintain the codebase.

### Implementation with Generic Repository

The Generic Repository implemented in this guide abstracts away the specifics of the data access layer. By using interfaces defined in the DataAccess.Core project, it allows for more flexible data operations that can work with any entity type. This approach not only simplifies the codebase but also enhances its extensibility for future development.

---


## Configuring Database Connection

To integrate the Repository Pattern and Unit of Work with your data management, you'll need to configure your database connection. This can be configured in your ppsettings.json file with the following connection string:

   ```json
      "ConnectionStrings": {
        "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=YourDatabaseName;Trusted_Connection=True;MultipleActiveResultSets=true"
      }
  ```

## Contributing
Your contributions are welcome! If you'd like to improve the guide, add examples, or correct any mistakes, please feel free to fork the repository and submit a pull request.

Fork the Project
1. Create your Feature Branch (git checkout -b feature/AmazingFeature)
2. Commit your Changes (git commit -m 'Add some AmazingFeature')
3. Push to the Branch (git push origin feature/AmazingFeature)
4. Open a Pull Request

## Search Keywords
- Repository Pattern .NET
- Unit of Work .NET
- Entity Framework Core Repository Pattern
- ASP.NET Core Repository Pattern

Thank you for checking out this guide. Don't forget to star the project if it helped you!
