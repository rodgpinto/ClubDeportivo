# Documentaci�n de Clases de Datos

## Clase Persona
Clase base que contiene los atributos y m�todos comunes para Socios y No Socios.

### Atributos
- `codigo`: Identificador �nico de la persona
- `nombre`: Nombre de la persona
- `apellido`: Apellido de la persona
- `dni`: N�mero de documento
- `direccion`: Direcci�n de residencia
- `fechaNacimiento`: Fecha de nacimiento

### M�todos
- `ListarPersonas(string procedimiento)`: Lista todas las personas seg�n el procedimiento almacenado
- `ObtenerIdPorDNI(string dni)`: Obtiene el ID de una persona por su DNI
- `ValidarPersona(string dni)`: Valida si una persona existe en el sistema

## Clase Socio
Hereda de Persona y agrega funcionalidad espec�fica para socios.

### Atributos Adicionales
- `fechaAlta`: Fecha en que se registr� como socio
- `estado`: Estado actual del socio (activo/inactivo)

### M�todos
- `ListarSocios()`: Lista todos los socios activos
- `ObtenerFotoPorSocioId(int socioId)`: Obtiene la foto del carnet de un socio
- `ObtenerIdPorDNI(string dni)`: Sobrescribe el m�todo de Persona para buscar espec�ficamente socios

## Clase NoSocio
Hereda de Persona y agrega funcionalidad espec�fica para no socios.

### Atributos Adicionales
- `fichaInscripcion`: Indica si tiene ficha de inscripci�n
- `actividad`: Actividad que realiza

### M�todos
- `ObtenerIdPorDNI(string dni)`: Sobrescribe el m�todo de Persona para buscar espec�ficamente no socios

## Clase Usuario
Maneja la autenticaci�n y autorizaci�n de usuarios del sistema.

### Atributos
- `id`: Identificador �nico del usuario
- `nombreUsuario`: Nombre de usuario para login
- `contrasena`: Contrase�a encriptada
- `rol`: Rol del usuario en el sistema

### M�todos
- `ValidarUsuario(string usuario, string contrasena)`: Valida las credenciales de un usuario
- `ObtenerRol(string usuario)`: Obtiene el rol de un usuario

## Clase Conexion
Singleton que maneja la conexi�n a la base de datos.

### M�todos
- `getInstancia()`: Obtiene la instancia �nica de la conexi�n
- `CrearConexion()`: Crea una nueva conexi�n a la base de datos

## Flujos de Datos

### Registro de Socio
1. Se crea una instancia de Persona con los datos b�sicos
2. Se crea una instancia de Socio con los datos espec�ficos
3. Se registra en la base de datos
4. Se genera el carnet

### Registro de No Socio
1. Se crea una instancia de Persona con los datos b�sicos
2. Se crea una instancia de NoSocio con los datos espec�ficos
3. Se registra en la base de datos
4. Se genera el comprobante de actividad

### Validaci�n de Usuario
1. Se crea una instancia de Usuario
2. Se validan las credenciales
3. Se obtiene el rol del usuario
4. Se permite o deniega el acceso 