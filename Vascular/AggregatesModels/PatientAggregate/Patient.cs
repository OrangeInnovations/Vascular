using Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vascular.AggregatesModels.PatientAggregate
{
    public class Patient: Entity<string>, IAggregateRoot
    {
        public string FirstName { get; set; }
        public string LasttName { get; set; }
        public string Title { get; set; }
    }
}
