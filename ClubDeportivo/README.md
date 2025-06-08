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