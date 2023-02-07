using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Domain.Entities
{
    public class FullAuditInfo
    {
        [ScaffoldColumn(false)]
        [Required]
        [StringLength(100)]
        [Display(Name = "Created By")]
        public string CreatedBy { get; set; }

        [ScaffoldColumn(false)]
        [Display(Name = "Created By Id")]
        public string CreatedById { get; set; }

        [ScaffoldColumn(false)]
        [Display(Name = "Created Date")]
        public DateTime CreatedDate { get; set; }

        [StringLength(39)]
        [ScaffoldColumn(false)]
        [Display(Name = "Created By IP Address")]
        public string CreatedByIp { get; set; }

        [StringLength(100)]
        [ScaffoldColumn(false)]
        [Display(Name = "Modified By")]
        public string ModifiedBy { get; set; }

        [ScaffoldColumn(false)]
        [Display(Name = "Modified By Id")]
        public string ModifiedById { get; set; }

        [ScaffoldColumn(false)]
        [Display(Name = "Modified Date")]
        public DateTime? ModifiedDate { get; set; }

        [StringLength(39)]
        [ScaffoldColumn(false)]
        [Display(Name = "Modified By IP Address")]
        public string ModifiedByIp { get; set; }
    }
}
