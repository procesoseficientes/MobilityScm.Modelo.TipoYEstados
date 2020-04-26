using System;
using System.Linq;
using System.Reflection;

namespace MobilityScm.Modelo.Tipos
{

    public enum PlantillaExcelTipo
    {
        [StringValue("1")]
        OrdenDeVenta,
        [StringValue("2")]
        ManifiestoDeCarga
    }

    public enum ClasificacionPickingTipo
    {
        [StringValue("3")]
        PickingPorTraslado,
        [StringValue("4")]
        PickingPorVenta,
        [StringValue("3076")]
        PickingPorReabastecimientoLp,
        [StringValue("0")]
        PickingPorVentaWMS
    }

    public enum SecuenciaTipo
    {
        [StringValue("GEOPOSITION")]
        Geoposicion
    }

    public enum SecuenciaManuales
    {
        [StringValue("3")]
        FrecuenciaManual
    }

    public enum ResultadoOperacionTipo
    {
        Exito = 1,
        Error = -1,
        Parcial = 0
    }

    public enum LenguajesTipo
    {
        English,
        Español
    }

    public enum RecepcionTipo
    {
        [StringValue("PO")]
        RecepcionPorCompra,
        [StringValue("RT")]
        RecepcionPorDevolucion,
        [StringValue("WT")]
        RecepcionPorTraslado,
        [StringValue("RR")]
        DevolucionPorReparacion
        ,
        [StringValue("RTR")]
        ReparacionPorLiquidacion
    }

    public enum TransaccionTipo
    {
        [StringValue("PO")]
        RecepcionDeCompra,
        [StringValue("PI")]
        Picking,
        [StringValue("TW")]
        TransferenciaEntreBodegas,
        [StringValue("RT")]
        Retorno,
        [StringValue("OV")]
        OrdenDeVenta,
        [StringValue("IN")]
        Factura,
        [StringValue("RTR")]
        SolicitudDeTransferenciaInventario,
        [StringValue("CU")]
        Cliente,
        [StringValue("UC")]
        CambioCliente
    }

    public enum ErrorInterface
    {
        RegistrarInsidenciaEntradaDeInventario = 3001,
        ObtenerOrdeneDeCompra = 3002,
        RegistrarInsidenciaEnSalidaDeInventario = 3002,
        ObtenerOrdenDeVenta = 3003,
        ProcessArrival = 3004,
        ProcessDispatch = 3005,
        EliminarTransaccion = 3006,
        ActualizarTransaccion = 3007,
        ProcesarOrdenesDeVentaPendientes = 3008,
        ProcesarOrdenesDeCompraPendientes = 3009,
        NoExisteElDocumento = 3010,
        RegistrarInsidenciaRetorno = 3011,
        ObtenerRetorno = 3012,
        ProcesRetornosPendientes = 3013
    }

    public enum PrivilegioTipo
    {
        [StringValue("BO")]
        BackOffice,
        [StringValue("MOB")]
        Mobile
    }

    public enum AccesoTipo
    {
        [StringValue("PRIVATE")]
        Privado,
        [StringValue("PUBLIC")]
        Publico
    }

    public enum TareasTipo
    {
        [StringValue("DELIVERY")]
        Entrega
        ,
        [StringValue("PRESALE")]
        Preventa
        ,
        [StringValue("SALE")]
        Venta
        ,
        [StringValue("SCOUTING")]
        Scouting
        ,
        [StringValue("TAREA_CONTEO_FISICO")]
        Conteo
        ,
        [StringValue("TAREA_PICKING")]
        TareaPicking
        ,
        [StringValue("TAREA_REUBICACION")]
        TareaReubicacion
    }

    public enum BroadCastOperacion
    {
        [StringValue("NUEVO")]
        Nuevo,
        [StringValue("BORRAR")]
        Borrar,
        [StringValue("ACTUALIZACION")]
        Actualizacion
    }

    public enum OrdenesErpTipo
    {
        [StringValue("SO")]
        OrdenVenta,
        [StringValue("IT")]
        OrdenInventarioTranslado
    }

    public enum PickingTipos
    {
        [StringValue("4")]
        OrdenDeVenta,
        [StringValue("3")]
        OrdenInventarioTraslado
    }

    public enum DocumentoTipo
    {
        [StringValue("SALES_ORDER")]
        OrdenDeVenta
        ,
        [StringValue("INVOICE")]
        Factura
        ,
        [StringValue("DRAFT")]
        Draft
    }

    public enum GrupoDeClasificaciones
    {
        [StringValue("CHANNEL_TYPE")]
        TiposDeCanal
        ,
        [StringValue("SUB_TYPE_POLYGON")]
        SubTipoDePoligono
        ,
        [StringValue("TIPOS_DE_CLASE")]
        TipoDeClase
        ,
        [StringValue("DEMANDA_DE_DESPACHO")]
        DemandaDeDespacho
        ,
        [StringValue("LINEAS_PICKING")]
        LineasDePicking
        ,
        [StringValue("PRIORITY")]
        Prioridad
        ,
        [StringValue("ESTADOS")]
        Estados
    }

    public enum TipoDeClasificaciones
    {
        [StringValue("SISTEMA")]
        Sistema
        , [StringValue("ESTADO")]
        Estado
    }

    public enum NombreDeClasificaciones
    {
        [StringValue("MANEJA_LINEA_DE_PICKING")]
        ManejaLineaDePicking,
        [StringValue("MANEJA_TONO_Y_CALIBRE")]
        ManejaTonoYCalibre,
        [StringValue("GPS")]
        Gps,
        [StringValue("ORDEN_DE_LLENADO")]
        OrdenDeLlenado
    }


    public enum AplicacionesDeAcuerdoComercial
    {
        [StringValue("CHANNEL")]
        Canal
        ,
        [StringValue("CUSTOMER")]
        Cliente
    }

    public enum EstadoDeCanal
    {
        [StringValue("ASIGNADO")]
        Asignado
        ,
        [StringValue("NO ASIGNADO")]
        NoAsignado
    }

    public enum TiposDePoligono
    {
        [StringValue("REGION")]
        Region
        ,
        [StringValue("SECTOR")]
        Sector
        ,
        [StringValue("RUTA")]
        Ruta
    }

    public enum GrupoDecimales
    {
        [StringValue("CALCULATION_RULES")]
        Region
        ,
        [StringValue("SECTOR")]
        Sector
        ,
        [StringValue("RUTA")]
        Ruta
    }

    public enum FuncionBoton
    {
        ACEPTAR = 1,
        GUARDAR = 2,
        SALIR = 3,
        CANCELAR = 4,
        INDEFINIDO = 5
    }

    public enum SkuManejaSerie
    {
        [StringValue("1")]
        Si
        ,
        [StringValue("0")]
        No
    }

    public enum Escanear
    {
        [StringValue("LICENSE")]
        Licencia
        ,
        [StringValue("MATERIAL")]
        Material
        ,
        [StringValue("BATCH")]
        Lote
        ,
        [StringValue("SERIAL_NUMBER")]
        Serie
        ,
        [StringValue("LOCATION")]
        Ubicacion
        ,
        [StringValue("MANIFEST")]
        Manifiesto
        ,
        [StringValue("LABEL")]
        Etiqueta
        , [StringValue("NADA")]
        Nada
        ,
        [StringValue("CAJA")]
        Caja
        , [StringValue("WAVE_PICKING")]
        OlaDePicking
    }
    public enum TipoDeBonificacionPorCombo
    {
        [StringValue("UNIQUE")]
        BonificacionUnica
        ,
        [StringValue("BY_COMBO")]
        BonificacionPorCombo
    }

    public enum SubTipoDeBonificacionPorCombo
    {
        [StringValue("UNIQUE")]
        Unica
        ,
        [StringValue("MULTIPLE")]
        Multiple
    }

    public enum TipoDeOperacionDeInterfaz
    {
        [StringValue("Importar")]
        Importar
        ,
        [StringValue("Enviar")]
        Enviar
    }

    public enum PrivilegioIdDeVista
    {
        [StringValue("btnTradeAgreement")]
        AcuerdoComercial
    }

    public enum DocumentoBase
    {
        OrdenDeVenta = 17
            , Factura = 13
    }
    public enum PadreDePrivilegio
    {
        [StringValue("SOLICITUD_DE_TRASLADO")]
        SolicitudDeTraslado
    }

    public enum CategorigaDePrivilegio
    {
        [StringValue("SECURITY")]
        Seguridad
    }

    public enum OpcionPermisos
    {
        [StringValue("UNBLOCK_POLIZAS_EXPIRADAS")]
        UNBLOCK_POLIZAS_EXPIRADAS,
        [StringValue("TCD001")]
        TrasladosEntreCd
    }
    public enum CampoFecha
    {
        [StringValue("DOCUMENT_DATE")]
        FechaDocumento,
        [StringValue("COMPLETED_DATE")]
        FechaCompletado
    }

    public enum TipoFuenteDemandaDespacho
    {
        [StringValue("SO - ERP")]
        OrdenVentaErp = 1,
        [StringValue("SO - SONDA")]
        OrdenVentaSonda = 2,
        [StringValue("WT - SWIFT")]
        SolicitudTrasladoWms = 3,
        [StringValue("WT - ERP")]
        SolicitudTrasladoErp = 4
    }

    public enum TipoDeInventario
    {
        [StringValue("General")]
        General = 1,
        [StringValue("Preparado")]
        Preparado = 2
    }

    public enum UsaLineaDePicking
    {
        [StringValue("Ambas")]
        Ambas = 2,
        [StringValue("Maneja Banda")]
        ManejanBanda = 1,
        [StringValue("No Maneja Banda")]
        NoManejanBanda = 0
    }

    public enum TipoDeManifiestoDeCarga
    {
        [StringValue("SALES_ORDER")]
        Venta,
        [StringValue("TRANSFER_REQUEST")]
        Transferencia
    }
    public enum TipoDocumentoExterno
    {
        [StringValue("CARGO_MANIFEST")]
        Manifiesto_Carga = 1
    }

    public enum TipoDemandaDespacho
    {
        [StringValue("SALES_ORDER")]
        OrdenVenta = 1,
        [StringValue("TRANSFER_REQUEST")]
        SolicitudTraslado = 2
    }


    public enum TipoDeDespachoParaPaseDeSalida
    {
        [StringValue("SALES_ORDER")]
        Venta = 1
        , [StringValue("TRANSFER_REQUEST")]
        Transferencia = 2
         , [StringValue("GENERAL_DISPATCH")]
        DespachoGeneral = 3
    }

    public enum FuenteDeRecepcionDeErp
    {
        [StringValue("PURCHASE_ORDER")]
        OrdenDeCompra = 0,
        [StringValue("INVOICE")]
        Factura = 1
    }

    public enum Regimen
    {
        [StringValue("GENERAL")]
        General = 1,
        [StringValue("FISCAL")]
        Fiscal = 2,
    }

    public enum SubTipoTarea
    {
        [StringValue("DEVOLUCION_FACTURA")]
        DevolucionDeFactura = 1,
        [StringValue("ENTREGA_NO_INMEDIATA")]
        EntregaNoInmediata = 2,
        [StringValue("INVENTARIO_PREPARADO")]
        InventarioPreparado = 3

    }

    public enum DocumentoDeEnvioErp
    {
        NotaDeEntrega = 1
        , FacturacionDePicking = 2
        , Recepciones = 3
        , MasterPack = 4
        , SolicitudDeTraslado = 5
        , NotaDeCredito = 6
        , ActualizacionNotaDeEntrega = 7
        , EntradaGeneralDeMercaderia = 8
        , SalidaGeneralDeMercaderia = 9
        , Devolucion = 10
    }

    public enum TipoDeVehiculo
    {
        FlotiaPropia = 1
        , Externo = 0
        , SinVehiculo = 3
    }

    public enum TipoDeGeneracionDeManifiestoDeCarga
    {
        [StringValue("POR_OLA")]
        PorOla,
        [StringValue("POR_PEDIDO")]
        PorPedido
    }

    public enum NombreParametroGeneral
    {
        [StringValue("TIPO_MANIFIESTO_DE_CARGA")]
        TipoManifiestoDeCarga,
        [StringValue("MOSTRAR_MONTOS")]
        MostrarMontos,
    }
    public enum ClienteDeImplementacion
    {
        [StringValue("Ferco")]
        Ferco = 1,
        [StringValue("Otros")]
        Otros = 2,
    }

    public enum GrupoParametro
    {
        [StringValue("NEXT")]
        Next = 1
        , [StringValue("PICKING_DEMAND")]
        DemandaDePicking = 2
        , [StringValue("SYSTEM")]
        Sistema = 3
        , [StringValue("PASS")]
        Pase = 4
        ,
        [StringValue("CERTIFICATION")]
        Certificacion = 5
        ,
        [StringValue("DELIVERED_DISPATCH")]
        EntregaDeDespacho = 6,
        [StringValue("RECEPCION")]
        Recepcion = 7,
        [StringValue("RAZON_DETALLE_LIBERACION")]
        RazonDetalleLiberacion = 8,
        [StringValue("DISPATCH_DEMAND_SOURCE_TYPE")]
        FuenteDemandaDespacho = 9,
        [StringValue("VALIDATE_TICKET_INCOME")]
        ValidarIngresoTicket = 10,
        [StringValue("VALIDATE_LOCATION")]
        ValidateLocation = 11,
        [StringValue("VALIDATE_QUANTITY")]
        ValidateQuantity = 12,
        [StringValue("TIPO_PASE_DE_SALIDA")]
        TipoSalida = 13,
        [StringValue("MATERIAL_SUB_FAMILY")]
        MaterialSubFamily = 14
    }


    public enum IdParametro
    {
        [StringValue("HAS_NEXT")]
        TieneNext = 1
        , [StringValue("GET_TYPE_OF_DEMAND")]
        ObtieneTipoDeDemanda = 2
        , [StringValue("GENERATE_INVOICE")]
        GeneraFactura = 3
        , [StringValue("SHOW_GUARANTEE_LABEL")]
        MostrarEtiquetaDeGarantia = 4
        ,
        [StringValue("PARTIAL")]
        Parcial = 5
        ,
        [StringValue("INSERT_OR_UPDATE_VEHICLE_AND_PILOT")]
        InsertarOActualizarVehiculoYPiloto = 6
        ,
        [StringValue("SHOW_IMMEDIATE_DELIVERY_SWITCH")]
        MostrarSwitchEntregaInmediata = 7
        ,
        [StringValue("CLIENT_MOBILE_IS_ANDROID")]
        TipoDeClienteMovilDe3Pl = 8
        ,
        [StringValue("RAZON_DETALLE_CANCELADO")]
        RazonDetalleCancelado = 9,
        [StringValue("LIBERACION_INVENTARIO")]
        LiberacionInventario = 10
        , [StringValue("DISPATCH_BY_STATUS")]
        DespachoPorEstadoDematerial = 11,
        [StringValue("AUTORIZACION_ENVIO_ERP_TRASLADO")]
        AutorizacionEnvioErpTraslado = 12,
        [StringValue("MUST_ENTER_TICKET")]
        DebeIngresarTicket = 13,
        [StringValue("INTEGRATION_NEXT")]
        IntegracionNEXT = 14,
        [StringValue("USE_EXIT_LOCATION")]
        UseExitLocation = 15,
        [StringValue("TAX_APPROVAL_AMOUNT")]
        TaxApprovalAmount = 16,
        [StringValue("SHOW_PANEL_CONDITIONS_LABEL")]
        MostrarEtiquetaDePanelCondiciones = 17,
        [StringValue("USE_MATERIAL_SUB_FAMILY")]
        UseMaterialSubFamily = 18
    }

    public enum TipoCertificacion
    {
        [StringValue("ETIQUETA")]
        Etiqueta = 1,
        [StringValue("MATERIAL")]
        Material = 2,
        [StringValue("CAJA")]
        Caja = 3
    }

    public enum EstadoPaseDeSalida
    {
        [StringValue("CREATED")]
        Creado = 1,
        [StringValue("FINALIZED")]
        Finalizado = 2,
        [StringValue("CANCELED")]
        Cancelado = 3
    }

    public enum TipoDeDatoParaPropiedades
    {
        [StringValue("INT")]
        Entero = 1,
        [StringValue("STRING")]
        Texto = 2
    }


    public enum PrioridadVehiculos
    {
        Peso = 1,
        Volumen = 2
    }

    public enum RelacionDataSetUnificacion
    {
        LICENCIA_A_MATERIAL,
        INFORMACION_MATERIAL
    }

    public enum Ok
    {
        OK
    }

    public enum TipoDescuento
    {
        [StringValue("PERCENTAGE")]
        Porcentual,
        [StringValue("MONETARY")]
        Monetario
    }

    public enum MensajeDeErrorDelApi
    {
        [StringValue("The user name or password is incorrect")]
        ContraseñaIncorrecta,
        [StringValue("Your licenses has blocked")]
        LicenciaBloqueada,
        [StringValue("Your licenses has expired")]
        LicenciaExpirada,
        [StringValue("Your company has blocked")]
        EmpresaBloqueada,
        [StringValue("You do not have access")]
        SinAcceso,
        [StringValue("User has blocked")]
        UsuarioBloqueado
    }

    public enum MensajeDeErrorDelApiTraducido
    {
        [StringValue("Usuario o contraseña incorrecto")]
        ContraseñaIncorrecta,
        [StringValue("Su licencia fue bloqueada")]
        LicenciaBloqueada,
        [StringValue("Su licencia ha expirado")]
        LicenciaExpirada,
        [StringValue("Su empresa ha sido bloqueda")]
        EmpresaBloqueada,
        [StringValue("No tiene acceso")]
        SinAcceso,
        [StringValue("Usuario bloqueado")]
        UsuarioBloqueado
    }

    public enum CapaMapaTracking
    {
        [StringValue("Bing")]
        Bing,
        [StringValue("Camion")]
        Camion,
        [StringValue("Rutas")]
        Rutas,
        [StringValue("Tareas")]
        Tareas
    }

    public enum CategoriaPermisos
    {
        [StringValue("SCREEN_SECURITY")]
        SeguridadDePantalla
    }
    public enum TipoDevolucion
    {
        [StringValue("ORIN")]
        NotaDeCredito,
        [StringValue("ORDN")]
        Devolucion
    }

    public enum Permiso
    {
        [StringValue("CAMBIAR_PRIORIDAD_TAREAS")]
        CambiarPrioridadDeTareas,
        [StringValue("PUEDE_LIBERAR_INVENTARIO")]
        PuedeLiberarInventario,
        [StringValue("PUEDE_AUTORIZAR_CONTROL_CALIDAD")]
        PuedeAutorizarControlDeCalidad,
        [StringValue("CONFIRMAR_TAREA_RECEPCION")]
        PuedeConfirmarRecepcion
    }

    public enum EstadoTarea
    {
        Pendiente,
        [StringValue("COMPLETA")]
        Completa
    }

    public enum Prioridad
    {
        Baja = 1,
        Media = 2,
        Alta = 3
    }

    public enum TipoVisualizacionTareasPicking
    {
        [StringValue("PickingTask")]
        PorTarea = 0,
        [StringValue("PickingTaskByLocation")]
        PorUbicacion = 1,
    }

    public enum TipoDescuentoPor
    {
        [StringValue("DISCOUNT_BY_GENERAL_AMOUNT_AND_FAMILY")]
        DescuentoPorMontoGeneralYFamilia = 0,
        [StringValue("DISCOUNT_BY_FAMILY_AND_PAYMENT_TYPE")]
        DescuentoPorFamiliaYTipoPago = 1,
    }

    public enum EstadosDeMetas
    {
        [StringValue("CREATED")]
        Creado = 0,
        [StringValue("IN_PROGRESS")]
        EnProgreso = 2,
        [StringValue("CANCELED")]
        Cancelado = 3,
        [StringValue("FINISHED")]
        Finalizado = 4,

    }

    public enum TipoDePago
    {
        [StringValue("CASH")]
        Efectivo,
        [StringValue("BANK_CHECK")]
        Cheque,
        [StringValue("BANK_DEPOSIT")]
        Deposito
    }

    public enum AccionEjecutadaSobreUsuario
    {
        Nuevo,
        Actualizado,
        Eliminado
    }

    public enum FuncionesWebApi
    {
        [StringValue("UpdateAddress")]
        ActualizarDireccion,
        [StringValue("GetUsers")]
        Usuarios,
        [StringValue("GetEntreprise")]
        Licencias,
        [StringValue("GetLicense")]
        Empresas,
        [StringValue("GetLicenseType")]
        TipoLicencia,
        [StringValue("GetApplications")]
        Applicaciones
    }

    public enum Status
    {
        Active = 1,
        Block = 0,
        Pending = 2
    }

    public enum AssignationType
    {
        Automatic = 1,
        OnDemand = 2

    }

    public enum ValidationTypes
    {
        PerDevice = 1,
        PerUser = 2
    }

    public enum ParametrosGeneralesGrupo
    {
        [StringValue("INVENTARIO_INACTIVO")]
        InventarioInactivo
    }

    public enum ParametrosGeneralesTipo
    {
        [StringValue("ALMACENAMIENTO")]
        Almacenamiento
    }

    public enum ErrorDeFechas
    {
        [StringValue("La fecha de finalización debe ser mayor a la de inicio.")]
        FechaFinMenor
    }
    public enum ErrorDeEncuesta
    {
        [StringValue("No existe encuesta asociada a esta pregunta.")]
        EncuestaInexistente,
        [StringValue("No existe pregunta asociada a esta respuesta.")]
        PreguntaInexistente,
        [StringValue("Se ha excedido del limite de preguntas permitidas.")]
        LimiteDePreguntas,
        [StringValue("La respuesta no debe estar vacía.")]
        RespuestaVacia,
        [StringValue("Parámetro de cantidad de preguntas permitidas no configurado, por favor, verifique y vuelva a intentar.")]
        ParametroDeMaximoDePreguntasNoConfiguradas
    }

    public enum ErrorDeActualizacionEnGrid
    {
        [StringValue(" solamente puede tener el valor único y no único.")]
        ValorNoValidoEnSkuPorEscala
    }

    public enum TiposDePromocion
    {
        [StringValue("SPECIAL_PRICE")]
        PrecioEspecial
    }

    public enum ExportarA
    {
        [StringValue("Excel")]
        Excel,
        [StringValue("Pdf")]
        Pdf
    }

    public enum ErrorEnPreciosEspeciales
    {
        [StringValue("No hay registros para actualizar.")]
        SinRegistrosAActualizar,
        [StringValue("Primero seleccione una promoción para eliminar.")]
        SinPromoParaEliminar,
        [StringValue("Rangos invalidos en el sku.")]
        RangoInvalido,
        [StringValue("Debe haber un valor en el campo del nombre de la promocipon.")]
        NombreSinValor,
        [StringValue("Se ha excedido de límite de caracteres establecidos para el nombre.")]
        CaracteresExcedentesEnNombre
    }

    public enum ApiOptions
    {
        [StringValue("ValidateCredentials")]
        ValidarCredenciales
    }

    public enum UrlApi
    {
        [StringValue("http://localhost:8088/SecurityAPI/odata/")]
        UrlDesarrollo,
        [StringValue("http://mobilitywebapi.centralus.cloudapp.azure.com:1025/SecurityAPI/odata/")]
        UrlProducion,
        [StringValue("http://190.56.115.27:9088/SecurityAPI/odata/")]
        UrlQA
    }
    public class RutasApi
    {
        private readonly string _valor;

        private RutasApi(string valor)
        {
            _valor = valor;
        }

        public class Tareas : RutasApi
        {
            private Tareas(string valor) : base(valor) { }

            public static readonly Tareas EnviarTareas = new Tareas("/v3/task/broadcastTasks");
        }

        public class InicioDeSesion : RutasApi
        {
            private InicioDeSesion(string valor) : base(valor) { }

            public static readonly RutasApi IniciarSesion = new InicioDeSesion("/v3/login/login");
        }

        public class Prueba : RutasApi
        {
            private Prueba(string valor) : base(valor) { }

            public static readonly RutasApi VerificarConexion = new Prueba("/v3/login/login");
        }

        public class ProcesarUsuariosApi : RutasApi
        {
            private ProcesarUsuariosApi(string valor) : base(valor) { }

            public static readonly RutasApi ProcesarUsuarios = new ProcesarUsuariosApi(Enums.GetStringValue(UrlApi.UrlProducion) + "ProcessSwiftUser");
        }

        public class ActualizarDireccionDeComunicacionDeLicenciaApi : RutasApi
        {
            private ActualizarDireccionDeComunicacionDeLicenciaApi(string valor) : base(valor) { }

            public static readonly RutasApi ActualizarDireccionDeComunicacion =
                new ActualizarDireccionDeComunicacionDeLicenciaApi(Enums.GetStringValue(UrlApi.UrlProducion) + "UpdateCommunicationAddress");
        }

        public class LiberarDispositivoApi : RutasApi
        {
            private LiberarDispositivoApi(string valor) : base(valor) { }

            public static readonly RutasApi LiberarDispositivo =
                new LiberarDispositivoApi(Enums.GetStringValue(UrlApi.UrlProducion) + "ReleaseDevice");
        }

        public class UsuarioApi : RutasApi
        {
            private UsuarioApi(string valor) : base(valor)
            {
            }

            public static readonly RutasApi AsociarUsuario = new UsuarioApi(Enums.GetStringValue(UrlApi.UrlProducion) + "LicenseAssingation");
            public static readonly RutasApi DesasociarUsuario = new UsuarioApi(Enums.GetStringValue(UrlApi.UrlProducion) + "RemoveLicenseDetail");
        }

        public override string ToString()
        {
            return _valor;
        }
    }

    public enum EstadoDeProyecto
    {
        [StringValue("CREATED")]
        Creado,
        [StringValue("IN_PROCESS")]
        EnProceso,
        [StringValue("COMPLETED")]
        Completado,
        [StringValue("FINALIZED")]
        Finalizado,
        [StringValue("CANCELLED")]
        Cancelado
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

            var attrs = fi.GetCustomAttributes(typeof(StringValueAttribute), false) as StringValueAttribute[];
            string output = "";
            if (attrs != null && attrs.Length > 0)
                output = attrs[0].Value;
            return output;
        }
    }

    #endregion
}