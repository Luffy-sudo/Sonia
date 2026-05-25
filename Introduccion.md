**Sistema de Gestión de Biblioteca**

Proyecto web full-stack aplicando los conceptos y patrones vistos durante el curso con la API Liga Deportiva (SportsLeague). El proyecto debe ser un sistema funcional y sencillo, con un dominio diferente al deportivo, que demuestre el dominio de las capas Backend y Frontend.

| Aspecto                 | Detalle                                                            |
| :---------------------- | :----------------------------------------------------------------- |
| **Backend**             | .NET 8 Web API                                                     |
| **Entidades sugeridas** | Book, Author, Category, Member, Loan.                              |
| **Extra sugerido**      | Historial de préstamos, multas por retraso, búsqueda por categoría |
| **Frontend**            |                                                                    |

<br/>

**Descripción**: Administración de libros autores, miembros y préstamos de una biblioteca.

- **_Entidades sugeridas_**: Book, Author, Category, Member, Loan.<br><br/>

- **_Extra sugerido_**: Historial de préstamos, multas por retraso, búsqueda por categoría.<br><br/>

**Requisitos técnicos**

| #   | Requisito                 | Descripción                                                  |
| :-- | :------------------------ | :----------------------------------------------------------- |
| 1   | Arquitectura por capas    | Mínimo 3 capas: _Domain_ _DataAccess_, _API_                 |
| 2   | Mínimo 5 entidades        | Con sus respectivas propiedades                              |
| 3   | Relaciones                | Al menos una relación 1:N y una N:M                          |
| 4   | Enums                     | Al menos un enum para estados o tipos                        |
| 5   | Repository Pattern        | GenericRepository + repositorios específicos si se necesitan |
| 6   | Services con validaciones | Lógica de negocio con validaciones en la capa de dominio     |
| 7   | DTOS + AutoMapper         | No exponer entidades directamente en los endpoints           |
| 8   | Migraciones con EF Core   | Code-First con EF Core                                       |
| 9   | Swagger funcional         | Todos los endpoints probados desde Swagger                   |
| 10  | DataSeeder                | Datos iniciales para poblar la BD automáticamente            |

<br>

**Frontend (A elección)**

| #   | Requisito               | Descripción                                                                           |
| :-- | :---------------------- | :------------------------------------------------------------------------------------ |
| 1   | Framework/Librería      | Angular, React, Vue, Blazor, o cualquier framework moderno                            |
| 2   | Consumo de API          | Conectarse al backend .NET 8 mediante HTTP                                            |
| 3   | Minimo 3 vistas/páginas | Listados, formularios de creación/edición, detalle                                    |
| 4   | Navegación              | Routing entre las diferentes vistas                                                   |
| 5   | Diseño presentable      | UI limpia y funcional (puede usar librerías como Material, Bootstrap, Tailwind, etc.) |

<br>

**Entregables**<br>

**1.** Repositorio en GitHub con el código fuente completo (Backend + Frontend).<br>
**2.** README.md con: nombre del proyecto, integrantes, descripción, instrucciones para ejecutar, tecnologías usadas.<br>
**3.** Base de datos funcional con DataSeeder (no se deben agregar datos manualmente para probar)<br>
**4.** Swagger funcionando correctamente.<br>
**5.** Frontend desplegado o ejecutable localmente con instrucciones claras.
