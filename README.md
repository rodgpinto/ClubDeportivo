# Club Deportivo - Sistema de Gestión

## Descripción General
Sistema de gestión para un club deportivo que permite administrar socios y no socios, incluyendo sus pagos, carnets y actividades.

## Estructura del Proyecto

### Formularios Principales
- **Login**: Sistema de autenticación de usuarios
- **MainMenu**: Menú principal de la aplicación
- **Registrar**: Formulario para elegir entre registrar socio o no socio
- **ModificarRegistros**: Formulario para elegir entre modificar socio o no socio

### Gestión de Socios
- **RegistrarSocio**: Registro de nuevos socios
- **ModificarSocio**: Modificación de datos de socios existentes
- **ConsultarSocio**: Consulta de información de socios
- **ListarSocios**: Listado de todos los socios
- **RegistrarPagoSocio**: Registro de pagos de cuotas de socios
- **HistorialPagosSocios**: Historial de pagos de socios

### Gestión de No Socios
- **RegistrarNoSocio**: Registro de nuevos no socios
- **ModificarNoSocio**: Modificación de datos de no socios existentes
- **ConsultarNoSocio**: Consulta de información de no socios
- **ListarNoSocios**: Listado de todos los no socios
- **RegistrarPagoNoSocio**: Registro de pagos de actividades de no socios
- **HistorialPagosNoSocios**: Historial de pagos de no socios

### Comprobantes y Carnets
- **Carnet**: Generación y visualización de carnets
- **ComprobantePago**: Generación de comprobantes de pago
- **ComprobanteActividad**: Generación de comprobantes de actividad

### Clases de Datos
- **Persona**: Clase base para Socio y NoSocio
- **Socio**: Manejo de datos de socios
- **NoSocio**: Manejo de datos de no socios
- **Usuario**: Manejo de usuarios del sistema
- **Conexion**: Gestión de la conexión a la base de datos

## Flujos de Trabajo Principales

### Registro de Socio
1. Ingreso de datos personales
2. Validación de DNI
3. Registro de pago inicial
4. Generación de carnet
5. Emisión de comprobante

### Registro de No Socio
1. Ingreso de datos personales
2. Validación de DNI
3. Selección de actividad
4. Registro de pago
5. Emisión de comprobante

### Modificación de Datos
1. Búsqueda por DNI
2. Validación de existencia
3. Modificación de datos
4. Confirmación de cambios

### Registro de Pagos
1. Búsqueda por DNI
2. Validación de existencia
3. Ingreso de monto y forma de pago
4. Registro del pago
5. Emisión de comprobante

## Base de Datos
El sistema utiliza MySQL como base de datos. Las principales tablas son:
- persona
- socios
- nosocios
- pagos
- carnet
- usuarios

## Requisitos del Sistema
- .NET Framework 4.7.2 o superior
- MySQL Server 8.0 o superior
- Windows 10 o superior

## Configuración
1. Instalar .NET Framework
2. Instalar MySQL Server
3. Restaurar la base de datos
4. Configurar la cadena de conexión en Conexion.cs
5. Compilar y ejecutar la aplicación 

# Documentación de Clases de Datos

## Clase Persona
Clase base que contiene los atributos y métodos comunes para Socios y No Socios.

### Atributos
- `codigo`: Identificador único de la persona
- `nombre`: Nombre de la persona
- `apellido`: Apellido de la persona
- `dni`: Número de documento
- `direccion`: Dirección de residencia
- `fechaNacimiento`: Fecha de nacimiento

### Métodos
- `ListarPersonas(string procedimiento)`: Lista todas las personas según el procedimiento almacenado
- `ObtenerIdPorDNI(string dni)`: Obtiene el ID de una persona por su DNI
- `ValidarPersona(string dni)`: Valida si una persona existe en el sistema

## Clase Socio
Hereda de Persona y agrega funcionalidad específica para socios.

### Atributos Adicionales
- `fechaAlta`: Fecha en que se registró como socio
- `estado`: Estado actual del socio (activo/inactivo)

### Métodos
- `ListarSocios()`: Lista todos los socios activos
- `ObtenerFotoPorSocioId(int socioId)`: Obtiene la foto del carnet de un socio
- `ObtenerIdPorDNI(string dni)`: Sobrescribe el método de Persona para buscar específicamente socios

## Clase NoSocio
Hereda de Persona y agrega funcionalidad específica para no socios.

### Atributos Adicionales
- `fichaInscripcion`: Indica si tiene ficha de inscripción
- `actividad`: Actividad que realiza

### Métodos
- `ObtenerIdPorDNI(string dni)`: Sobrescribe el método de Persona para buscar específicamente no socios

## Clase Usuario
Maneja la autenticación y autorización de usuarios del sistema.

### Atributos
- `id`: Identificador único del usuario
- `nombreUsuario`: Nombre de usuario para login
- `contrasena`: Contraseña encriptada
- `rol`: Rol del usuario en el sistema

### Métodos
- `ValidarUsuario(string usuario, string contrasena)`: Valida las credenciales de un usuario
- `ObtenerRol(string usuario)`: Obtiene el rol de un usuario

## Clase Conexion
Singleton que maneja la conexión a la base de datos.

### Métodos
- `getInstancia()`: Obtiene la instancia única de la conexión
- `CrearConexion()`: Crea una nueva conexión a la base de datos

## Flujos de Datos

### Registro de Socio
1. Se crea una instancia de Persona con los datos básicos
2. Se crea una instancia de Socio con los datos específicos
3. Se registra en la base de datos
4. Se genera el carnet

### Registro de No Socio
1. Se crea una instancia de Persona con los datos básicos
2. Se crea una instancia de NoSocio con los datos específicos
3. Se registra en la base de datos
4. Se genera el comprobante de actividad

### Validación de Usuario
1. Se crea una instancia de Usuario
2. Se validan las credenciales
3. Se obtiene el rol del usuario
4. Se permite o deniega el acceso 

# Documentación de Formularios

## Formularios de Registro

### RegistrarSocio
Formulario para el registro de nuevos socios.

#### Campos
- Nombre
- Apellido
- DNI
- Dirección
- Fecha de Nacimiento
- Ficha de Inscripción (checkbox)
- Apto Físico (checkbox)
- Cuota
- Forma de Pago
- Foto para Carnet

#### Funcionalidades
- Validación de DNI único
- Registro de pago inicial
- Generación de carnet
- Emisión de comprobante

### RegistrarNoSocio
Formulario para el registro de nuevos no socios.

#### Campos
- Nombre
- Apellido
- DNI
- Dirección
- Fecha de Nacimiento
- Ficha de Inscripción (checkbox)
- Actividad
- Monto
- Forma de Pago

#### Funcionalidades
- Validación de DNI único
- Registro de actividad
- Emisión de comprobante

## Formularios de Modificación

### ModificarSocio
Formulario para modificar datos de socios existentes.

#### Funcionalidades
- Búsqueda por DNI
- Modificación de datos personales
- Actualización de foto de carnet
- Eliminación de socio

### ModificarNoSocio
Formulario para modificar datos de no socios existentes.

#### Funcionalidades
- Búsqueda por DNI
- Modificación de datos personales
- Eliminación de no socio

## Formularios de Pago

### RegistrarPagoSocio
Formulario para registrar pagos de cuotas de socios.

#### Campos
- DNI
- Monto
- Forma de Pago
- Fecha de Pago
- Fecha de Vencimiento

#### Funcionalidades
- Búsqueda por DNI
- Registro de pago
- Emisión de comprobante

### RegistrarPagoNoSocio
Formulario para registrar pagos de actividades de no socios.

#### Campos
- DNI
- Actividad
- Monto
- Forma de Pago
- Fecha de Pago
- Fecha de Vencimiento

#### Funcionalidades
- Búsqueda por DNI
- Registro de pago
- Emisión de comprobante

## Formularios de Consulta

### ConsultarSocio
Formulario para consultar datos de socios.

#### Funcionalidades
- Visualización de datos personales
- Visualización de estado de pago
- Visualización de carnet

### ConsultarNoSocio
Formulario para consultar datos de no socios.

#### Funcionalidades
- Visualización de datos personales
- Visualización de actividades
- Visualización de pagos

## Formularios de Listado

### ListarSocios
Formulario para listar todos los socios.

#### Funcionalidades
- Listado de socios
- Filtrado por estado
- Acceso rápido a modificación
- Generación de carnet

### ListarNoSocios
Formulario para listar todos los no socios.

#### Funcionalidades
- Listado de no socios
- Filtrado por actividad
- Acceso rápido a modificación

## Formularios de Comprobantes

### Carnet
Formulario para visualizar e imprimir carnets.

#### Funcionalidades
- Visualización de datos del socio
- Visualización de foto
- Impresión de carnet

### ComprobantePago
Formulario para visualizar e imprimir comprobantes de pago.

#### Funcionalidades
- Visualización de datos del pago
- Impresión de comprobante

### ComprobanteActividad
Formulario para visualizar e imprimir comprobantes de actividad.

#### Funcionalidades
- Visualización de datos de la actividad
- Impresión de comprobante 