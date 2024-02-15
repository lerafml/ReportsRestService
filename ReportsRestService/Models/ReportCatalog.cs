using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReportsRestService.Models
{
    public class ReportCatalog
    {
       public short Index { get; set; }
       public string Name { get; set; }
       public string Description { get; set; }
       public string Template { get; set; }
      public string Parameters { get; set; }
    }
}