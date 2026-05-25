 #!/bin/bash

```bash
# Crear la solución
dotnet new sln -n Sonia

# =========================
# Crear proyectos
# =========================

# Proyecto API (Web API)
dotnet new webapi -n Sonia.API -controllers

# Proyecto Domain (Class Library)
dotnet new classlib -n Sonia.Domain

# Proyecto DataAccess (Class Library)
dotnet new classlib -n Sonia.DataAccess

# Proyecto Application (Class Library)
dotnet new classlib -n Sonia.Application

# =========================
# Agregar proyectos a solución
# =========================

dotnet sln add Sonia.API/Sonia.API.csproj
dotnet sln add Sonia.Domain/Sonia.Domain.csproj
dotnet sln add Sonia.DataAccess/Sonia.DataAccess.csproj
dotnet sln add Sonia.Application/Sonia.Application.csproj

# =========================
# Configurar referencias
# =========================

# API --> Application
dotnet add Sonia.API/Sonia.API.csproj reference Sonia.Application/Sonia.Application.csproj

# Application --> Domain
dotnet add Sonia.Application/Sonia.Application.csproj reference Sonia.Domain/Sonia.Domain.csproj

# DataAccess --> Domain
dotnet add Sonia.DataAccess/Sonia.DataAccess.csproj reference Sonia.Domain/Sonia.Domain.csproj
```

**Resultado esperado:**

Sonia.API puede acceder a:

- DTOs
- Services
- UseCases

Sonia.Application puede acceder a:

- Entities
- Interfaces
- Enums
- Reglas de negocio

A través de:

```bash
Sonia.Domain
```

Sonia.DataAccess puede acceder a:

- Entities
- Repository Interfaces

para implementar:

- EF Core
- DbContext
- Repositories

**Lo más importante**

Application no conoce:

- SQL Server
- EF Core