using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Dal;

namespace Task.Models
{
    public class Procedure
    {
        private readonly Lazy<IEnumerable<ProcedureParams>> _params;
        public string Name { get; set; }
        public string Definition { get; set; }
        public Database Database { get; set; }
        public Procedure()
        {
            _params = new Lazy<IEnumerable<ProcedureParams>>(() => RepositoryFactory.GetRepository().GetParams(this));
        }
        public ICollection<ProcedureParams> Params { get => new List<ProcedureParams>(_params.Value); }
        public override string ToString() => this.Name;
    }
}
