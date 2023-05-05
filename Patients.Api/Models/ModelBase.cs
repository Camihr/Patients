using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Patients.Api.Models
{
    public class ModelBase
    {
        [Column("feregistro")]
        public DateTime Created { get; set; }

        [Column("febaja")]
        public DateTime? Deleted { get; set; }
    }
}
