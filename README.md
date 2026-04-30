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
- [Visual Studio 2019 (version 16.6+)]( https://visualstudio.microsoft.com/downloads) (version 16.6 or later)  
- [.NET Core SDK 3.1.3+](https://dotnet.microsoft.com/download/dotnet-core/3.1) or later  
- ASP.NET Core environment setup  

## Installation and Running the Application
1. Clone or download the repository .
2. Open the solution in Visual Studio 2019.
3. In the **Server** project, update the database connection string in the `appsettings.json` file.
4. Ensure that the `NorthWind.MDF` database file is correctly placed in the **Shared** project.
5. Build and run the solution.
6. Launch the application in the browser to view CRUD operations in the TreeView.

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

## Additional Resources
- **TreeView Entity Framework data binding:**  
  https://blazor.syncfusion.com/documentation/treeview/data-binding/#entity-framework

## Troubleshooting
- Verify the database file path in `appsettings.json`.
- Ensure SQL Server LocalDB is accessible.
- Rebuild the solution if Entity Framework migrations or packages fail.
- Check browser and server logs for runtime or API errors.

## Support
For detailed API references, configuration options, and advanced scenarios, refer to the Syncfusion Blazor TreeView documentation links above.
To get more help, check the [ASP.NET Core Blazor documentation](https://docs.microsoft.com/en-us/aspnet/core/blazor).