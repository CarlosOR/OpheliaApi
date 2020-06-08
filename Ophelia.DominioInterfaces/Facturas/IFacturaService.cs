using Ophelia.DTO.Facturas;

namespace Ophelia.DominioInterfaces.Facturas
{
    public interface IFacturaService
    {
        bool Facturar(DTOFactura factura);
    }
}
