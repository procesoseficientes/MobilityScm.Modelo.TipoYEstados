using System;
using System.Linq;
using System.Reflection;

namespace MobilityScm.Modelo.Configuracion
{
    public enum Cliente
    {
        [StringValue("UMBRA")]
        Umbra,
        [StringValue("ALUTECH")]
        Alutech
    }

    public static class Configuracion
    {
        public static readonly string ImagenPorDefecto = "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";
        public static readonly string ImagenCamion = "iVBORw0KGgoAAAANSUhEUgAAACAAAAAgCAYAAABzenr0AAAFbklEQVRYR+2WW2xUVRSG/33mzIVCGOkAbSEtEC/tAxfRRAui8IAEJUSmTbmFGAMIJlAj+kKIxogJgYAKhATaQLwQExSZUqAWDEgvXBKQCoZQHgixNUZpC1NoO53pnLO22ZczM8y0ogmmPjAPc3LW2Zdvrb3WvzbDIP/YIO+PRwCPIvD/iMClPWu5rAaNw4lAZIOcJyfYVp8ckrTZIE7IGEsEKx67wonKy7aebXxQlcktL1Ws5SOnvCDHcm6DCxzx1AAgAtebcUraBWS6HeCI3O3A781Nf5ZtPZv3zwAqyyVAb9ctDcHl5mIzcBUNzpM2samEcgDkNwFmy/m+odm4cfEUSjbVP/CIVQQqy3lg8jREu9sB6gOJEMgNMj0XQDJK8pvzVEDieBg43FkB3GyqR8mmhn8DUIzerjZwu0+cQ8rmyTAjNeQpmwsYBWBLADNrJI5fjfHzxkxGhheMLB1R5VA0Gr9sEV/d+NnCC5Lwpz0qB3q7O8BEBMRi8sy5PIJEqPVGHBrKyQtnjI6A4Qug9hrh8Vkr+02BP9rDOHqm+de67UsmSICLFeW8cOEGcNtKThDnLLIe4jhkeqpvMkPFm4DLtMtiMhh2VXwpAdrv9mRATMj1o+LQOdRsKWMS4MLuNbxo8fv/GUDZjAkY5jMTIHHLxvJN1ajevEgBNO5cza/mL0bEtnUOCBeF78J78c/l2UnvRX7op65Xeb4yJvLJYJhe3Lv5CybOXiEjsGpuEXzuZD7G4hYWfvAdjmxZogDqd7zJrxUsfagA4Rs/Y8qcVRKguCgHzz2ZnYhAVABs+AZHty1TAGd2LOejJ09D5N5tMJndKsmUtynv0svku/RYjtGJqnXAPWQ4appNFM5ZKwE8bjeefSIbk8ePgAEgGrNQsn4/Tu5aoQG2v8HHTJ2OaFcHOPUl1C1Rdqm1LzfVGpGhhKoMmS+A75tNPDX37UQSDvF6MNRnwmUwZHkM7Nz/QxKg4dPXed7UGegVQpTQgZRS0zWvJFlEwNEJJUQJOxfKyWF4s1F73YXCV97ptwpG+Ydi74ET+HH3Kp0DnyzjYyRAhwRI6DtsvXiqx+oYkv0hqYYCjnEC8wZwXAC8um5AgMqva1FX+ZYCOL1tKR/7tAagmNJ9qff3NxvhnRCpdLvKF907QDC8o1B73UDRvHcHBKjYfwz1e9cogLqti/nYZ15CtOeOVMJEBGRndELsJJpOxPSGJGFFMxJHEEDNNYaiee8NCLDnq2No2JcCkD1JtWOy4jrE6j6gmo/TlHQF6FyQGuH0BN28lEtAzVXCpOD6ROkxOwru8iXed38eQuMX69TwlQte5C7TDdXLOJi8mWjBAQfZSpSSUqLlWIuSoSRL/sQKYp322DBEPKMB5tLyLSKnxokW0xOJoqnukMMLLCubW9jVa542DJaXP64AHo9bLhjvi6O1pRU2J4wryIfX55MrWLaN1t9aYVnUPRyRmV539Pa+0LmWFSXTx/WyLFdPfMgpMDY+b0wBPF63hLcsGy0tLQLxbqTPnHn6RNWV+/r1gmDwWyIqe8zvR05Orryitd1qQ7gzLGH8fj9yc3LBGENbWzvuhG8DhlF/pKpqVnrHeW1ByQFwe5GakwPIObcQDnfCxdjJ0OHDL6uIpfyCweBEocxElG2aqnlYlgXDMCIAYkQ0Is0eJaI51dXVGXe/0tLSIiJqIKJR/aw1u6qq6nwGgDCUlpZOJaKNtm0/zxhjhmE0McY+ZIx1EtFm27anK7NxmTG2MRQKNaR777wHg8EpjLGPLcsq1nPEWh+FQqGzzpgBr0zz588f6fP52MGDB9vTohQwTdNItw8EIezBYHDAOQ+8s/3dwg/j26AD/AUOOIpddUxIWAAAAABJRU5ErkJggg==";
        public static readonly string ImagenPinMapa = "iVBORw0KGgoAAAANSUhEUgAAAC4AAAAsCAYAAAAacYo8AAAAGXRFWHRTb2Z0d2FyZQBBZG9iZSBJbWFnZVJlYWR5ccllPAAABRFJREFUeNrEWVFoFEcY/vcOE86aNq2l1/ZEK0RqbWwSLPVMGm0efFEK9cmH4oOkotCHUn2xCIXah1qsL3mIAVPKEYP2xYgG8U2b0ERoQ5NAJZiAQiPEpik9T5KYcPf3/3bn4mVv7nZzOxcHPrI3u/N9307+mf1nxmJmKlQsyyI/hdPpOgqFDlAm0yQ/3xW8Lr+dxpkMBKYEf0rdr/K7xwqHRyhogfFC8GG4VZ4b4dFR5tOnmffuZY7F0HI5UId7eAbPoo20XXXjInpQ7g/wlSvMO3bkG/UC2qAtOIRrVYyL0Hf84AFzS8vKDbsBDnAJZ1mNi0An37rFXFUV3HQW4AKncJfFuBB38M2bzKGQ3gDi+MgR5q4uJ45TKQe4Rh3u6eIfACe4RcOocSH8nO/eZa6s1AsfO8Y8OMieBc/gWR0HuKEhWkaMC1ElP33KXFubL1ZdzXzuHK+4oA3auvmgAS3RNGH8a25r0/dSKaZzzes4oSWagYwLKuweiEb14RG06MIGWtAU7SDGP+Fr1/QD0U9M+4l53YCFpmgX8x0q+laZzMd0/Xp+/b59RPF44K+2zQEud4EmtEs2TtRIg4P5tbt3k7Gi43I0G0sPlXR6XjsFOvmGmQIu3dQo2sV8Wx7JFJMuQ0yliNatM9PjT54QVVXpehTZqVVqjKfpeRUPba8YT9L69fm19++bM6jjcjSTQYxPUTSaXzsyYs64jsvRnApifJTq6/Nr+/rMGddxQXNyckKuXhWs1fn0Mj5MDQ35tTduEN25E9w0OMDlLtAcHh5H0AhigjfUC1h+jfdp59mHD4kSieDGwQEu3dze3j6kjMIjprA3BS8vmff45IdkPtVncuVKsqAlmq8R1Yq9dxS2Ct4W1Aiq/WaHP3Fra2ERk2ktAK2hoatqtwDY5nqBtwRr/Bjfw/39xZdfJhYSWUBr//7DIr2dnF53v8AWxLvlta8i9y35GGRoq7zs+HjheI3FnIQJ8VlXR7R587N5GlMeZg8MRF1MZ8sW8TQ2Ri+Ew/Wz+Go7IFp+ncEo87t0+5Lb280tkAsBGhcu/IAJUSBvT+8pbHf9B0KWn50sMR6hhYVZ2rCBaGamPJ94fC0nJ+lAJNIoAT5foLfx9z/BXyE/nFY4PEcVFd/SyZPly03A3dvbKaYXcqZBy3WN8o9ndpibnEmvvyi9nqSamuJxWkrB+JiYoC8ikZY2yRddPZz9m1ZpwN9+PkC5vf5Yev0UnTljvrfBefnyeTE9q+ntLP4VTPvKx93p8NIM09xMNDBgxnSjLHT6+ykSDu+az4/n7N/HgvGcOv89rl4EDQ9RZ6e53gbX8ePfqOWOpQHS23u5poPs1v5obxkHnf7A0dPzm1pf7lKIK+wUbBKETW4zR3lxsbQt5tytZuHoIMJqvkmZz77AByqpMr+xb2/qj40xRyIrN402aHviBEb6hwpNCu8LXir3icR57u5euXG0uXjxd6FoVsia31YwNEwat9tPT1/1TJzcCVlv7x/IunOw0z43Wq0zINXrDfZeXzzubRrPyLMyg3wmTfcoIPeoWNXDqyWOVOowP3rEvHFjYdO4h2eOHsWxyUdq5njluZy6LeNJJr+yB5zumAV1uHf2bIeK6U2+Y7ncxm2uubnv7YVA7nELrlGXSHSr5dcaIx8uk8ZV2HTJ4HtmHNe3b/+iVunmimnjNufiYoIvXWIbMzM/lyMLtkwciReYbT5VWWV3OYz/L8AAqcr6S3TeBEMAAAAASUVORK5CYII=";

    }

    public enum Swift3PlPestania
    {
        NEXT
        , WMSALMACENADORA
        , WMSBACKOFFICE
        , WMSCONFIG
    }

    public enum Swift3PlOpcionesWms
    {
        CATALOGO_BIN
        , CATALOGO_CLIENTES
        , CATALOGO_PRODUCTOS
        , CATALOGO_UBICACIONES
        , CATALOGO_ZONAS
        , CLASES
        , CATALOGO_ASEGURADOAS
        , CERTIFICADO
        , CONSULTA_VEN_POLIZAS
        , INSPECCIONES
        , POLIZAS_SEGURO
        , REPORTE_CERTIFICADO_BONO
        , REPORTE_SEGURO
        , CATALOGO_CONSULTA_COSTEO
        , INFO_INV_CONSOL
        , INFO_INV_ONLINE
        , INFO_TRANS_ONLINE
        , INFO_WMS_BALC_OF_PAY
        , INFO_WMS_MASTER_PACK
        , INFO_WMS_NIVEL_OCUPACION
        , INFO_WMS_VIEW_INV
        , INFO_WMS_VR_SAP
        , CREAR_CONTEO
        , CREAR_TAREA_REAB
        , CREAR_TAREA_REUB
        , CREAR_TAREA_VARIA
        , ADMIN_TAREAS
        , ADMINISTRADOR_DE_LINEA_DE_PICKING
        , ASIGNAR_USUARIOS_PICK
        , CONSOLIDAR_PICKING
        , CREAR_OLA_PICKING
        , CREAR_PICKING_D
        , PEDIDOS_SIN_ASIGNAR
        , CATALOGOS
        , CERTIFICATE_GROUP
        , INV_GROUP
        , TASK_GROUP
        , TASK_PICKING
        , CONSULTA_INVENTARIO_DIARIO
        , REPORTE_PICKING
        , INFO_INV_INACTIVO
        , SUGERIDO_COMPRA
        , INFO_INDICES_BODEGA
        , CS_ADMINISTRADOR_TAREA
    }

    public enum Swift3PlOpcionesAlmacenadora
    {
        AUDITORIAS
        , SERV_ADIC
        , CONSULTA_BACKORDERS
        , INV_DOC
        , MOV_FISCAL
        , POLIZAS_EXPIRADAS
        , TRAS_DOC
        , ASIGNACION_CONTEO_FISICO
        , CONSULTA_CONTEO_FISICO
        , EGRESO_GENERAL
        , EGRESO_POLIZA
        , ORDEN_PREPARADO
        , PASE_SALIDA
        , REPORTE_EGRESO
        , ACUSE_RECIBO
        , APROBACION_FISCAL
        , AUTORIZACION_CUPO
        , AUTORIZACION_SAT
        , COSTEAR_GENERAL
        , GARITA
        , INGRESO_FISCAL
        , INGRESO_GENERAL
        , REPORTE_INGRESO_FISCAL
        , CONSULTA_SOLICITUD_DE_TRASLADO
        , SOLICITUD_DE_TRASLADO
        , ACUERDO_COMERCIAL
        , CONS_ACUERDO_CLIENTE
        , INV_POR_ACUERDO_COMERCIAL
        , TARIFARIO
        , TIPO_COBRO
        , GRUPO_AUDITORIAS
        , GRUPO_BACKORDERS
        , GRUPO_CONSULTA_DOC
        , GRUPO_CONTEO_FISICO
        , GRUPO_DESPACHO
        , GRUPO_RECEPCION
        , GRUPO_SOLICITUD_TRASLADO
        , GRUPO_TARIFARIO
        , INGRESO_ERP
        , CERTIFICADO_DEPOSITO
        , INGRESO_EXTERNO
        , PASE_DE_SALIDA
        , EGRESO_EXTERNO
        , RECTIFICACIONES
        , GRUPO_BLOQUEO_INVENTARIO
        , BLOQUEO_DE_INVENTARIO
        , REPORTE_DEVOLUCIONES
        , GRUPO_INVENTARIO_COMPROMETIDO
        , INVENTARIO_COMPROMETIDO
    }

    public enum Swift3PlOpcionesNext
    {
        DESPACHO
        , DEMANDA_DESPACHO
        , MANIFIESTO_DE_CARGA
        , ENTREGA
        , GRUPO_MOVIMIENTOS
        , TRAZABILIDAD_DEMANDA
        , TRANSPORTE
        , CATALOGO_EMPRESAS_DE_TRANSPORTE
        , CATALOGO_PILOTOS
        , CATALOGO_VEHICULOS
        , CONSULTA_DE_MANIFIESTO
        , COSULTAS_Y_TRANSACCIONES
        , PEDIDOS_POR_VENDEDOR
        , CONSULTA_LINEA_DE_PICKING
        , CONSULTA_CUMPLIMIENTO_ENTREGA
    }

    public enum Swift3plOpcionesConfiguracion
    {
        INTERFASE_GRAFICA
        , PARAMS
        , CATALOGO_USUARIOS
        , NIVEL_ACCESO
        , CONFIG_GROUP
        , SEGURIDAD_GROUP
        , USUARIOS
        , AGREGAR_LICENCIA
    }

    public enum Swift3plCategory
    {
        ROOT
        , PAGE
        , GROUP
        , OPTION
    }

    public enum Swift3plRibbonItemStyle
    {
        Default
        , All
        , Large
        , SmallWithText
        , SmallWithoutText
    }


    #region "Auxiliares"

    public class StringValueAttribute : Attribute
    {

        private readonly string _value;

        public StringValueAttribute(string value)
        {
            _value = value;
        }

        public string Value
        {
            get { return _value; }
        }

    }



    public static class Enums
    {
        public static string GetStringValue(Enum value)
        {

            Type type = value.GetType();
            FieldInfo fi = type.GetField(value.ToString());


            var attrs = fi.GetCustomAttributes(typeof(Tipos.StringValueAttribute), false) as Tipos.StringValueAttribute[];
            string output = "";
            if (attrs != null && attrs.Length > 0)
                output = attrs[0].Value;
            return output;
        }

        public static T GetEnumValueFromStringValue<T>(string description)
        {
            var type = typeof(T);
            if (!type.IsEnum)
                throw new ArgumentException("Error de tipo.");
            var fields = type.GetFields();
            var field = fields
                            .SelectMany(f => f.GetCustomAttributes(
                                typeof(StringValueAttribute), false), (
                                    f, a) => new { Field = f, Att = a }).SingleOrDefault(a => ((StringValueAttribute)a.Att)
                                .Value == description);
            return field == null ? default(T) : (T)field.Field.GetRawConstantValue();
        }

    }

    #endregion
}