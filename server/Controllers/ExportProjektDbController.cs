using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Projekt.Data;

namespace Projekt
{
    public partial class ExportProjektDbController : ExportController
    {
        private readonly ProjektDbContext context;

        public ExportProjektDbController(ProjektDbContext context)
        {
            this.context = context;
        }
    }
}
