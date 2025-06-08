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