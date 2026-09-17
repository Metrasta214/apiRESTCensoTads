
<div align="center">

# INSTITUTO TECNOLÓGICO DE PACHUCA

### Taller Avanzado de Desarrollo de Software

**Proyecto: apiRESTCensoTads**

**Alumno:** Álvaro Madrid Morales

</div>

---

## Descripción del proyecto

Este proyecto consiste en el desarrollo de una API REST utilizando ASP.NET Web API con C#. La API permite realizar operaciones para consultar, registrar, actualizar y eliminar información de personas mediante peticiones HTTP.

## Tecnologías utilizadas

- C#
- ASP.NET Web API
- .NET Framework 4.7.2
- Visual Studio
- Postman

## Funcionalidades

La API permite realizar las siguientes operaciones:

| Método HTTP | Operación | Descripción |
|---|---|---|
| GET | Consultar registros | Obtiene todos los registros disponibles. |
| GET por ID | Consultar registro | Busca un registro mediante su identificador. |
| POST | Registrar | Agrega información en una posición del arreglo. |
| PUT | Actualizar | Modifica la información de un registro. |
| DELETE | Eliminar | Limpia los datos de un registro. |

## Estructura del proyecto

```text
apiRESTCensoTads/
├── Controllers/
│   └── CensoController.cs
├── Models/
│   └── clsCenso.cs
├── Properties/
├── README.md
├── apiRESTCensoTads.slnx
└── COLLECTIONS.postman_collection.json
```

## Modelo de datos

El modelo `clsCenso` contiene los siguientes atributos:

- `id`
- `curp`
- `nombre`
- `apellidoPaterno`
- `apellidoMaterno`
- `direccion`
- `actividadEconomica`

## Pruebas con Postman

Las peticiones se prueban mediante Postman utilizando la ruta base:

```text
https://localhost:44325/api/Censo
```

La colección de peticiones se encuentra en el archivo:

```text
COLLECTIONS.postman_collection.json
```

## Ejecución del proyecto

1. Abrir `apiRESTCensoTads.slnx` en Visual Studio.
2. Ejecutar el proyecto con **F5**.
3. Abrir Postman.
4. Enviar las peticiones HTTP a la ruta de la API.

---

<div align="center">

**Instituto Tecnológico de Pachuca**

Taller Avanzado de Desarrollo de Software

</div>
