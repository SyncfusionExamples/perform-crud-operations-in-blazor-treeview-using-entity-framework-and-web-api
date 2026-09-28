# Perform CRUD Operations in Blazor TreeView Using Entity Framework and Web API

## Overview

This sample demonstrates how to use the Syncfusion [Blazor TreeView](https://www.syncfusion.com/blazor-components/blazor-treeview) component in an ASP.NET CoreWebAssembly application with Entity Framework and Web API. The application binds hierarchical records from a database, exposes data operations through API endpoints, and allows users to manage nodes through TreeView CRUD interactions. The sample is useful for implementing editable organizational structures, navigation hierarchies, category trees, and other database-driven hierarchical interfaces.

## Key Features

- Displays database-backed hierarchical data in a Syncfusion TreeView.
- Uses Entity Framework as the data-access layer.
- Uses Web API endpoints for client-server communication.
- Demonstrates Create, Read, Update, and Delete operations on TreeView nodes.
- Adds a context menu to the TreeView to expose CRUD actions.
- Supports creating child nodes with automatically incremented unique identifiers.
- Demonstrates synchronization between TreeView operations and persistent database records.
- Uses an ASP.NET Core hosted Blazor WebAssembly architecture with separated Client, Server, and Shared projects.
- Uses database records stored in the Northwind sample database configuration referenced by the application.

## Prerequisites

- Visual Studio 2022 or Visual Studio Code
- .NET SDK compatible with the project's target framework

## How to Run the Project

**Visual Studio 2022**

1. Clone or download this repository.
2. Open the solution file:

   `MyBlazorApp.sln`

3. Restore all NuGet packages.
4. Set the startup project to:

   `Server`

5. Open the following configuration file:

   `Server/appsettings.json`

6. Update the connection string path to the Northwind database.
7. Build the solution.
8. Run the application using `Ctrl+F5`.
9. Verify that the TreeView loads hierarchical data and supports add, edit, and delete operations through the context menu.

**Visual Studio Code**

1. Open the repository folder in Visual Studio Code.
2. Open the integrated terminal.
3. Navigate to the repository root.

```bash
cd perform-crud-operations-in-blazor-treeview-using-entity-framework-and-web-api
```

4. Restore NuGet packages.

```bash
dotnet restore
```

5. Run the server project.

```bash
dotnet run --project Server
```

6. Open the application URL displayed in the terminal and verify TreeView CRUD functionality.

## Project Structure


`Client/Pages/Index.razor` — hosts the Syncfusion TreeView implementation, context menu integration, and client-side CRUD interactions.

`Server/Controllers/*.cs` — exposes Entity Framework-backed CRUD endpoints consumed by the client application.

`Server/appsettings.json` — stores database connection configuration used by Entity Framework.

`Shared/App_Data/NORTHWND.MDF` — database file referenced by the sample configuration.

## Support and Feedback

- For general product questions, visit the [Syncfusion Community Forum](https://www.syncfusion.com/forums) or [Syncfusion Support](https://www.syncfusion.com/support).
- To report an issue specific to this sample, open a GitHub issue in this repository.
- Official documentation: https://blazor.syncfusion.com/documentation/treeview/data-binding/#entity-framework

## License

This is a Syncfusion sample project provided to demonstrate product usage. Review the [Syncfusion license terms](https://www.syncfusion.com/sales/pricing?category=ui-components) before using Syncfusion components in your own applications.