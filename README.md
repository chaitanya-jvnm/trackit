Welcome to the TrackIt App repository! This application helps you track and manage your daily habits efficiently. Built using a .NET Core Web API backend, this app is designed to provide a seamless experience for users looking to build and maintain positive habits.

## Technologies

Backend: .NET Core Web API

## Installation

### Prerequisites
.NET Core SDK (version 6.0 or higher)
SQL Server / PostgreSQL / Your Database of Choice or Database Setup Guide

## Steps

1. Clone the repository:

```bash
git clone https://github.com/yourusername/trackit.git
cd trackit
```

2. Navigate to the backend directory:
```bash
cd TrackIt.Api
```

3. Restore the .NET Core dependencies:
```bash
dotnet restore
```

4. Set up the database:

Refer to the Database Setup Guide for detailed instructions on setting up your database.

5. Run the migrations:
```bash
dotnet ef database update
```

6. Start the API:
```bash
dotnet run
```

## Usage
Once the application is running, you can interact with it through the API endpoints. You can use tools like Postman or cURL to test the API.

### API Endpoints:

