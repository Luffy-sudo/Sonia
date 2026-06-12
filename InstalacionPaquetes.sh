#!/bin/bash

# =========================================================
# 🚀 SONIA - Instalación de paquetes por capa
# Arquitectura Clean Architecture + .NET 8
# =========================================================

echo "========================================="
echo "📦 Instalando paquetes en SONIA"
echo "========================================="

# =========================================================
# 🟦 SONIA.DataAccess
# =========================================================

echo ""
echo "📁 Entrando a SONIA.DataAccess..."
cd Sonia.DataAccess

echo "📦 Instalando Entity Framework Core..."

dotnet add package Microsoft.EntityFrameworkCore -v 8.0.*
dotnet add package Microsoft.EntityFrameworkCore.SqlServer -v 8.0.*
dotnet add package Microsoft.EntityFrameworkCore.Tools -v 8.0.*

cd ..

# =========================================================
# 🟩 SONIA.Application
# =========================================================

echo ""
echo "📁 Entrando a SONIA.Application..."

cd Sonia.Application

echo "📦 Instalando paquetes de Application..."

# AutoMapper
dotnet add package AutoMapper --version 13.0.1

# FluentValidation
dotnet add package FluentValidation

# Logging abstractions
dotnet add package Microsoft.Extensions.Logging.Abstractions

# Dependency Injection abstractions
dotnet add package Microsoft.Extensions.DependencyInjection.Abstractions

cd ..

# =========================================================
# 🟦 SONIA.API
# =========================================================

echo ""
echo "📁 Entrando a SONIA.API..."

cd Sonia.API

echo "📦 Instalando paquetes de API..."

# EF Tools
dotnet add package Microsoft.EntityFrameworkCore.Tools -v 8.0.*

# Swagger
dotnet add package Swashbuckle.AspNetCore

# AutoMapper DI
dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection --version 12.0.1

cd ..

# =========================================================
# 🟥 SONIA.Domain
# =========================================================

echo ""
echo "📁 Entrando a SONIA.Domain..."

cd Sonia.Domain

echo "📦 Instalando paquetes mínimos de Domain..."

dotnet add package Microsoft.Extensions.Logging.Abstractions

cd ..

# =========================================================
# ✅ Restaurar solución
# =========================================================

echo ""
echo "🔄 Restaurando paquetes de la solución..."

dotnet restore

echo ""
echo "========================================="
echo "✅ Instalación finalizada correctamente"
echo "========================================="