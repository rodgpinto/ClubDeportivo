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