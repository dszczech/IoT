using System.Reflection;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;


namespace Projekt.Data
{
  public partial class ProjektDbContext : Microsoft.EntityFrameworkCore.DbContext
  {
    public ProjektDbContext(DbContextOptions<ProjektDbContext> options):base(options)
    {
    }

    public ProjektDbContext()
    {
    }

    partial void OnModelBuilding(ModelBuilder builder);

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);


        this.OnModelBuilding(builder);
    }

  }
}
