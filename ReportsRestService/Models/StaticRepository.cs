using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReportsRestService.Models
{
    public class StaticRepository : IExampleRepository
    {
        public List<ReportCatalog> Catalog
        {
            get
            {
                return new List<ReportCatalog>
            {
                new ReportCatalog{  Index=0, Name="Report Catalog",Description="Report Catalog", Template= "Report Catalog.trdp" },
                new ReportCatalog{  Index=1, Name="Barcodes Report",Description="This example illustrates the range of barcode signatures Telerik Reporting utilizes.", Template= "Barcodes Report.trdp" },
                new ReportCatalog { Index = 2, Name = "Dashboard", Description = "Performance overview of the AdventureWorks Sales Department.", Template = "Dashboard.trdp", Parameters = "{ ReportYear:2002}" },
                new ReportCatalog { Index = 3, Name = "Employee Sales Summary", Description = "Displays sales statistics for an individual employee per month.", Template = "Employee Sales Summary.trdp", Parameters = "{ Employee:283, ReportDate: \"" + DateTime.Now.Date + "\"}" },
                new ReportCatalog { Index = 4, Name = "Invoice", Description = "Invoice implemented with Master-Detail reports.", Template = "Invoice.trdp" },
                new ReportCatalog { Index = 5, Name = "List Bound Report", Description = "Displays data from a set of Business Objects.", Template = "ListBoundReport.trdp" },
                new ReportCatalog { Index = 6, Name = "Olympic Medals by National Teams", Description = "Map layout of the Olympic medals by national teams and associations.", Template = "OlympicMedalsByNationalTeams.trdp" },
                new ReportCatalog { Index = 7, Name = "Population Density", Description = " A choropleth map, showing the population density in the 100 most populated countries.", Template = "PopulationDensity.trdp" },
                new ReportCatalog { Index = 8, Name = "Product Catalog", Description = " Product Catalog Report. (Multilingual)", Template = "Product Catalog.trdp" },
                new ReportCatalog { Index = 9, Name = "Product Line Sales", Description = " Top ten best performing sales people and stores.", Template = "Product Line Sales.trdp" },
                new ReportCatalog { Index = 10, Name = "Product Sales", Description = " Crosstab summary of AdventureWorks sales, grouped by product category over a 4 year period.This is about 120 000 rows of data.", Template = "Product Sales.trdp" },
                new ReportCatalog { Index = 11, Name = "Product Tag Report", Description = " Printable product tags arranged in a newspaper - style columns.", Template = "Product Tag Report.trdp" },
                new ReportCatalog { Index = 12, Name = "Sales by Region Dashboard", Description = " Sales distribution across the world.", Template = "SalesByRegionDashboard.trdp" },
                new ReportCatalog { Index = 13, Name = "Report Book", Description = " A collection of Product - related reports.", Template = "ReportBook.trbp" },

            };
            }
        }
    }
}