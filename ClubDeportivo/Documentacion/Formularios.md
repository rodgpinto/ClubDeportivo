# Documentaci�n de Formularios

## Formularios de Registro

### RegistrarSocio
Formulario para el registro de nuevos socios.

#### Campos
- Nombre
- Apellido
- DNI
- Direcci�n
- Fecha de Nacimiento
- Ficha de Inscripci�n (checkbox)
- Apto F�sico (checkbox)
- Cuota
- Forma de Pago
- Foto para Carnet

#### Funcionalidades
- Validaci�n de DNI �nico
- Registro de pago inicial
- Generaci�n de carnet
- Emisi�n de comprobante

### RegistrarNoSocio
Formulario para el registro de nuevos no socios.

#### Campos
- Nombre
- Apellido
- DNI
- Direcci�n
- Fecha de Nacimiento
- Ficha de Inscripci�n (checkbox)
- Actividad
- Monto
- Forma de Pago

#### Funcionalidades
- Validaci�n de DNI �nico
- Registro de actividad
- Emisi�n de comprobante

## Formularios de Modificaci�n

### ModificarSocio
Formulario para modificar datos de socios existentes.

#### Funcionalidades
- B�squeda por DNI
- Modificaci�n de datos personales
- Actualizaci�n de foto de carnet
- Eliminaci�n de socio

### ModificarNoSocio
Formulario para modificar datos de no socios existentes.

#### Funcionalidades
- B�squeda por DNI
- Modificaci�n de datos personales
- Eliminaci�n de no socio

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
- B�squeda por DNI
- Registro de pago
- Emisi�n de comprobante

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
- B�squeda por DNI
- Registro de pago
- Emisi�n de comprobante

## Formularios de Consulta

### ConsultarSocio
Formulario para consultar datos de socios.

#### Funcionalidades
- Visualizaci�n de datos personales
- Visualizaci�n de estado de pago
- Visualizaci�n de carnet

### ConsultarNoSocio
Formulario para consultar datos de no socios.

#### Funcionalidades
- Visualizaci�n de datos personales
- Visualizaci�n de actividades
- Visualizaci�n de pagos

## Formularios de Listado

### ListarSocios
Formulario para listar todos los socios.

#### Funcionalidades
- Listado de socios
- Filtrado por estado
- Acceso r�pido a modificaci�n
- Generaci�n de carnet

### ListarNoSocios
Formulario para listar todos los no socios.

#### Funcionalidades
- Listado de no socios
- Filtrado por actividad
- Acceso r�pido a modificaci�n

## Formularios de Comprobantes

### Carnet
Formulario para visualizar e imprimir carnets.

#### Funcionalidades
- Visualizaci�n de datos del socio
- Visualizaci�n de foto
- Impresi�n de carnet

### ComprobantePago
Formulario para visualizar e imprimir comprobantes de pago.

#### Funcionalidades
- Visualizaci�n de datos del pago
- Impresi�n de comprobante

### ComprobanteActividad
Formulario para visualizar e imprimir comprobantes de actividad.

#### Funcionalidades
- Visualizaci�n de datos de la actividad
- Impresi�n de comprobante 