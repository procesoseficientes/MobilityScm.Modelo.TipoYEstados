using System;
using MobilityScm.Modelo.Tipos;

namespace MobilityScm.Modelo.Estados
{

    public enum EstadoCajaLineaPicking
    {
        [StringValue("ASSIGNED")]
        Asignada = 1,
        [StringValue("ALLOWED_TO_PICK")]
        Pendiente = 2,
        [StringValue("PICKED")]
        Despachado = 3
    }

    public enum SerieEstado
    {
        [StringValue("AVAILABLE")]
        Disponible,
        [StringValue("USED")]
        Utilizada
    }
    public enum SiNo
    {
        [StringValue("1")]
        Si = 1,
        [StringValue("0")]
        No = 0

    }

    public enum EventoEstado
    {
        ProcesoAutomaticoIniciado = 1000,
        ProcesoAutomaticoFinalizado = 1001,
        ProcesandoIngreso = 1002,
        ProcesandoPicking = 1003,
        ProcesandoRetorno = 1004,
        ProcesandoTransferencia = 1005,
        ErrorEnEnvio = 1006,
        ProcesandoOrdenesDeVenta = 1007,
        ProcesandoRecepcion = 1008,
        ProcesandoExplosionMasterPack = 1009,
        ProcesandoSolicitudDeTraslado = 1010,
        ProcesandoActualizacionDeNotasDeEntrega = 1011,
        ProcesandoNotaDeCredito = 1012,
        ProcesandoEntradaGeneralDeMercaderia = 1013,
        ProcesandoSalidaGeneralDeMercaderia = 1014,
        ProcesandoEnvioDePagos = 1015
    }




    public enum EnvioTransaccionEstado
    {
        [StringValue("01")]
        NoSePudoObtenerOrdeneDeCompra,
        [StringValue("02")]
        NoSePudoMarcarEntradaDeInventarioComoEnviadaAErp,
        [StringValue("03")]
        NoSePudoCrearDocDeEtradaDeInventario,
        [StringValue("11")]
        NoSePudoObtenerOrdeneDeVenta,
        [StringValue("12")]
        NoSePudoMarcarSalidaDeInventarioComoEnviadaAErp,
        [StringValue("13")]
        NoSePudoCrearDocDeSalidaDeInventario,
        [StringValue("50")]
        NoSePudoObtenerDocumento,

        [StringValue("21")]
        NoSePudoObtenerRetorno,
        [StringValue("22")]
        NoSePudoMarcarRetornoComoEnviadoAErp,
        [StringValue("03")]
        NoSePudoCrearDocDeRetorno,
        [StringValue("30")]
        NoSePudoCrearOrdenDeVenta,

        [StringValue("40")]
        NoSePudoCrearFactura,

        [StringValue("61")]
        NoSePudoObtenerLaSolicitudDeTransferenciaInventario,
        [StringValue("63")]
        NoSePudoCrearLaSolicitudDeTransferenciaInventario,
        [StringValue("71")]
        NoSePudoCrearCliente,
        [StringValue("72")]
        NoSePudoActualizarCliente
    }

    [Flags]
    public enum CreacionRecepcion
    {
        CrearDocDeEntradaDeInventarioErp = 1,
        MarcarEntradaDeInventarioComoEnviadaAErp = 2
    }


    [Flags]
    public enum CreacionDeRetorno
    {
        CrearRetornoErp = 1,
        MarcarRetornoComoEnviadaAErp = 2
    }

    [Flags]
    public enum CreacionDespacho
    {
        CrearDocDeSalidaDeInventario = 1,
        MarcarSalidaDeInventarioComoEnviadaAErp = 2
    }

    public enum ScoutingEstado
    {
        [StringValue("ACCEPTED")]
        Aceptado,
        [StringValue("REJECTED")]
        Rechazado,
        [StringValue("NEW")]
        Nuevo
    }

    public enum ScoutingEnviadoErp
    {
        [StringValue("1")]
        Enviado,
        [StringValue("-2")]
        Errado,
        [StringValue("-1")]
        Pendiente
    }

    public enum PickingEstado
    {
        [StringValue("ASSIGNED")]
        Asignada,
        [StringValue("COMPLETED")]
        Completado,
        [StringValue("CLOSED")]
        Cerrado
    }

    public enum EnviadoErpRecepcion
    {
        [StringValue("1")]
        Enviado = 1,
        [StringValue("-1")]
        Errado = -1,
        [StringValue("0")]
        Pendiente = 0
    }

    public enum EstadoDeTransferencia
    {
        [StringValue("PENDIENTE")]
        Pendiente,
        [StringValue("COMPLETADO")]
        Completado,
        [StringValue("CANCELADO")]
        Cancelado,
        [StringValue("TRANSFERIDO")]
        Transferido
    }

    public enum ErrorPicking
    {
        SalidaDeInventario = -1,
        EntradaDeInventario = -2,
        Entrega = -3,
        ErrorGeneral = -4
    }

    public enum PickingCompletado
    {
        SalidaDeInventario = 1,
        EntradaDeInventario = 2,
        Entrega = 3
    }

    public enum PickingOrigen
    {
        PickingsFallidos = 0,
        PickingsNuevos = 1
    }

    public enum EstadoPolizaFiscal
    {
        [StringValue("FREE")]
        FREE,
        [StringValue("FULL_BLOCK")]
        FULL_BLOCK
    }

    public enum EstadoSolicitudDeTraslado
    {
        [StringValue("OPEN")]
        OPEN,
        [StringValue("CLOSED")]
        CLOSED
    }

    public enum OrdenDeVenta
    {
        [StringValue("Posteada")]
        Posteada,
        [StringValue("No Posteada")]
        NoPosteada

    }

    public enum InnerSaleStatus
    {
        [StringValue("SALE_INVOICE")]
        SALE_INVOICE,
        [StringValue("PURCHASE_INVOICE")]
        PURCHASE_INVOICE,
        [StringValue("FINAL_INVOICE")]
        FINAL_INVOICE
    }

    public enum EscanerEnImplosion
    {
        EscanearLicencia = 1,
        EscanearMaterial = 2
    }

    public enum EstadosManifiesto
    {
        [StringValue("CANCELED")]
        Cancelado,
        [StringValue("IN_PICKING")]
        EnPicking,
        [StringValue("CREATED")]
        Creado,
        [StringValue("CERTIFIED")]
        Certificado,
        [StringValue("CERTIFYING")]
        Certificando
    }

    public enum EscanerEnUnificacion
    {
        EscanearUbicacion = 1,
        EscanearMaterial = 2
    }

    public enum EstadoEntregaDocumento
    {
        [StringValue("PARTIAL")]
        Parcial = 1,
        [StringValue("DELIVERED")]
        Entregado = 2,
        [StringValue("PENDING")]
        Pendiente = 3,
        [StringValue("CANCELED")]
        Cancelado = 4
    }

    public enum EstadoTareaDeEntrega
    {
        Completa = 1,
        Parcial = 2,
        Siguiente = 3,
        Cancelada = 4,
        Pendiente = 5
    }


    public enum EstadosDeEntrega
    {
        [StringValue("CREATED")]
        Creado,
        [StringValue("COMPLETED")]
        Completado,
        [StringValue("PARTIAL")]
        Partial,
        [StringValue("PICKED")]
        Picked,
        [StringValue("DELIVERED")]
        Entregado,
    }

    public enum EstadoDeEtiqueta
    {
        EtiquetaYaExiste = 2,
        EtiquetaInsertada = 1
    }
}