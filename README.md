# Modelo.TipoYEstados
Este repo contiene todos los modelos y tipos compartidos entre los proyectos del backoffice de Sonda (SWift Express) y WMS

### Nota sobre el API de licencia
La dirección del difunto "API de Licencias" está en el enum `urlApi` en el archivo `Tipos.cs` en la linea `893`.
Ahora está la url del mock del api de licencias que siempre retorna verdadero, en un futuro hay que cambiar todas las veces que se menciona este enum en los proyectos y actualizar a los clientes.

El proyecto mock está en: https://github.com/procesoseficientes/license-api-mock