# TodoList-DotnetCoreMVC
Simple Todo app with .NET Core MVC and Microsoft SQL Server

## Installation
Run the following command in the NuGet Package Manager console

```cmd
PM> Install-Package Microsoft.EntityFrameworkCore -Version 6.0.2
```

```cmd
PM> Install-Package Microsoft.EntityFrameworkCore.SqlServer -Version 6.0.2
```

```cmd
PM> Install-Package Microsoft.EntityFrameworkCore.Tools -Version 6.0.2
```

```cmd
PM> Install-Package Microsoft.VisualStudio.Web.CodeGeneration -Version 6.0.2
```

```cmd
PM> Install-Package Microsoft.VisualStudio.Web.CodeGeneration.Design -Version 6.0.2
```

## Setup Database
```
PM> add-migration AddTodoToDatabase
```

```
PM> update-datebase
```