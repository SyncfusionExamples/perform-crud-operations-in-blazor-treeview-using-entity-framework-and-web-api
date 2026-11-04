# Perform CRUD Operations in Blazor TreeView Using Entity Framework and Web API

**Repository Description**  
This repository contains a quick‑start Blazor WebAssembly (ASP.NET Core hosted) sample that demonstrates how to perform Create, Read, Update, and Delete (CRUD) operations on the Syncfusion Blazor TreeView component using Entity Framework and Web API.

The sample explains how to bind hierarchical data from a database, add a context menu to the TreeView, and manage TreeView nodes dynamically, including adding new nodes by incrementing unique node IDs.

## Project Overview
The purpose of this project is to help developers understand how to integrate the Syncfusion Blazor TreeView component with Entity Framework and Web API in a hosted Blazor WebAssembly application. It serves as a reference implementation for building data‑driven, interactive TreeView structures backed by a database.

## Features
- Integration of Syncfusion Blazor TreeView component  
- Perform CRUD operations using Entity Framework  
- Use Web API for data communication  
- Context menu support for TreeView nodes  
- Dynamic node creation with unique ID handling  
- Display hierarchical data from a database  

## Examples
- Online demo:  
  https://blazor.syncfusion.com/demos/treeview/remote-data

## Prerequisites
Before running this project, ensure the following are installed:
- [Visual Studio Code](https://code.visualstudio.com/) or [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) (with the .NET 10 workload)
- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)
- SQL Server LocalDB

## Installation and Running the Application

### Clone and Open the Project
1. Clone or download the repository.
2. Open the solution file (`MyBlazorApp.sln`) in Visual Studio 2022 or Visual Studio Code.

### Configure the Database Connection
Update the database connection string in the **Server** project's `appsettings.json` file to point to your local `NORTHWND.MDF` file location:
```json
"ConnectionStrings": {
  "EmployeeDatabase": "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='D:\\MyBlazorApp\\Shared\\App_Data\\NORTHWND.MDF';Integrated Security=True;Connect Timeout=30"
}
```

### Run the Application
1. Build the solution.
2. Run the project (the **Server** project is the startup project).
3. Open the application in the browser to view CRUD operations in the TreeView.

## Usage
Run the application to:
- View hierarchical TreeView data loaded from the database  
- Use the context menu to add, edit, or delete nodes  
- Persist changes using Entity Framework and Web API  

This approach can be used for admin panels, file explorers, organizational charts, or category management systems.

## Documentation
- **General Syncfusion documentation:**  
  https://help.syncfusion.com/
- **Blazor Introduction:**  
  https://blazor.syncfusion.com/documentation/introduction
- **Blazor TreeView Getting Started:**  
  https://blazor.syncfusion.com/documentation/treeview/getting-started
- **TreeView Entity Framework data binding:**  
  https://blazor.syncfusion.com/documentation/treeview/data-binding/#entity-framework

## Troubleshooting
- Verify the database file path in `Server/appsettings.json`.
- Ensure SQL Server LocalDB is installed and accessible.
- Rebuild the solution if Entity Framework or TreeView components fail to load.
- Check browser and server logs for runtime or API errors.

## Support
For detailed API references, configuration options, and advanced scenarios, refer to the Syncfusion Blazor TreeView documentation links above.
To get more help, check the [ASP.NET Core Blazor documentation](https://learn.microsoft.com/en-us/aspnet/core/blazor/).