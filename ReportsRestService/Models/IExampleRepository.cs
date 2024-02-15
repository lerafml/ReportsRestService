using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportsRestService.Models
{
    public interface IExampleRepository
    {
        List<ReportCatalog> Catalog{ get; }
    }
}
