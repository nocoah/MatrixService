using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouService.Data.Domain.Majors;

namespace YouService.Data.Mappers.Majors
{
    public partial class MajorMap : DataEntityTypeConfigurationBase<Major>
    {
        public MajorMap()
        {
            this.ToTable(DbTables.Majors);
            this.HasKey(x => x.Id);
        }
    }
}