using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using GestionAdministrativa.Data.Helpers;
using GestionAdministrativa.Entities;

namespace GestionAdministrativa.Business.Interfaces
{
    public interface IReporteNegocio : IDisposable
    {

        List<ComprobantesByVentaId_Result> ComprobantesByVentaId(Guid ventaId);

    }
}
