### 🚀 SONIA — Backend API

Sistema backend desarrollado bajo una arquitectura en capas basada en principios de Clean Architecture y separación de responsabilidades, utilizando .NET y Entity Framework Core.

---

### 🎯 Objetivo del Proyecto

SONIA es una API REST diseñada para gestionar los diferentes procesos del sistema, manteniendo una estructura escalable, mantenible y desacoplada.

Aunque el desarrollo funcional aún no ha comenzado completamente, la arquitectura base ya fue definida para garantizar:

- 📈 Escalabilidad
- 🔗 Bajo acoplamiento
- 🧩 Alta cohesión
- 🛠️ Facilidad de mantenimiento
- 🧠 Separación clara de responsabilidades
- 🧪 Facilidad para pruebas unitarias e integración

---

### 🏗️ Arquitectura del Proyecto

La solución está organizada en cuatro proyectos principales:

- SONIA.API
- SONIA.Application
- SONIA.Domain
- SONIA.DataAccess

---

### 📂 Estructura General

```text
SONIA.API
    ↓
SONIA.Application
    ↓
SONIA.Domain

SONIA.DataAccess
    ↓
SONIA.Domain
```

---

### 📘 Descripción de cada proyecto

<br>

#### 🌐 SONIA.API

Capa de presentación y exposición de endpoints REST.

#### Responsabilidades:

- 🎮 Controllers
- 📄 Configuración de Swagger
- 🔌 Configuración de Dependency Injection
- 🛡️ Middlewares
- ⚠️ Manejo global de excepciones
- 🌍 Configuración del pipeline HTTP

#### Tecnologías:

- ASP.NET Core Web API
- Swagger / OpenAPI

---

#### ⚙️ SONIA.Application

Capa de aplicación y lógica de negocio.

#### Responsabilidades:

- 📦 DTOs
- 🧠 Services
- ✅ Validaciones
- 🛠️ Casos de uso
- 🔄 AutoMapper
- 📋 Reglas de aplicación

> _Esta capa no debe conocer detalles de persistencia ni Entity Framework Core._

---

#### ❤️ SONIA.Domain

Núcleo del sistema.

#### Responsabilidades:

- 🧱 Entidades
- 📑 Interfaces
- 🔢 Enums
- 📜 Reglas de dominio
- 🗂️ Contratos de repositorios

Esta capa representa el corazón del negocio y no depende de ninguna otra capa.

---

#### 🗄️ SONIA.DataAccess

Capa de persistencia.

#### Responsabilidades:

- 🧭 DbContext
- ⚙️ Configuraciones FluentAPI
- 🏛️ Implementación de repositorios
- 📦 Migraciones
- 🌱 Seeders
- 💾 Acceso a base de datos

## Tecnologías:

- Entity Framework Core
- SQL Server

---

#### 🧠 Principios Arquitectónicos

El proyecto sigue principios inspirados en:

- 🏗️ Clean Architecture
- 📐 SOLID
- 🔌 Dependency Injection
- 🗃️ Repository Pattern
- 🎯 Separation of Concerns

---

#### ⚠️ Reglas Importantes

- 🚫 La capa Domain no debe depender de ninguna otra capa.
- 🔒 Application no debe depender de DataAccess; la comunicación con persistencia debe hacerse mediante interfaces definidas en Domain.
- 📦 Los DTOs pertenecen a Application: los DTOs no deben ubicarse en Domain.

---

#### 🛤️ Flujo de Desarrollo Planeado

El desarrollo seguirá el siguiente orden:

1. 🧱 Entities
2. 🔗 Relationships
3. 🧭 DbContext
4. ⚙️ FluentAPI Configurations
5. 📦 Migrations
6. 📑 Repository Interfaces
7. 🏛️ Repository Implementations
8. 🧠 Services
9. 📦 DTOs
10. 🔄 AutoMapper
11. 🌐 Controllers
12. 🧪 Swagger Testing
13. 🌱 Seeders
14. 🚀 Deployment

<br>

#### 📌 Estado Actual

Actualmente el proyecto se encuentra en fase de configuración arquitectónica y estructuración inicial.

La base de la solución ya está preparada para iniciar el desarrollo de:

- 🧱 Entidades
- 💾 Persistencia
- 🧠 Servicios
- 🌐 Endpoints REST
- 📦 Migraciones
- ✅ Validaciones

<br>

#### 🎯 Objetivo Técnico

Construir una API mantenible, extensible y preparada para crecimiento futuro, evitando acoplamientos innecesarios y aplicando buenas prácticas desde el inicio del proyecto.

```

```
