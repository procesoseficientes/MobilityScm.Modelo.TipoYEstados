# Modelo.TipoYEstados
Este repo contiene todos los modelos y tipos compartidos entre los proyectos del backoffice de Sonda (SWift Express) y WMS

### Nota sobre el API de licencia
La dirección del difunto "API de Licencias" está en el enum `urlApi` en el archivo `Tipos.cs` en la linea `893`.
Ahora está la url del mock del api de licencias que siempre retorna verdadero, en un futuro hay que cambiar todas las veces que se menciona este enum en los proyectos y actualizar a los clientes.

El proyecto mock está en: https://github.com/procesoseficientes/license-api-mock

## ------------------------------------------------------------

### Pasos para actualización de paquetes nuget
1. Descargar el proyecto
2. Realizar las modificaciones correspondientes
3. Cambiar la versión del proyecto
> Dar doble clic al poyecto y en el apartado versión agregar la nueva versión del paquete, siguiendo los estandares de la versión
4. Compilar
5. Subir los cambios al repositorio
6. Subir los cambios del paquete nuget
   + Primero se tiene que instalar gpr en github
   ```
   dotnet tool install --global gpr --version 0.1.285
   ```
   + Ejecutar el siguiente comando con la siguiente sintaxis
   ```
   gpr push bin/Release/MobilityScm.UtileriasMobilityScm.Modelo.TipoYEstados.<version actual del paquete>.nupkg -k <GITHUB PAT>
   ```
