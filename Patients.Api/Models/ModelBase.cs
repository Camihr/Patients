using System.ComponentModel.DataAnnotations.Schema;

namespace Patients.Api.Models
{
    public class ModelBase
    {
        [Column("feregistro")]
        public DateTime Created { get; set; }
        
        [Column("feactulizacion")]
        public DateTime Updated { get; set; }

        [Column("febaja")]
        public DateTime? Deleted { get; set; }
    }
}
