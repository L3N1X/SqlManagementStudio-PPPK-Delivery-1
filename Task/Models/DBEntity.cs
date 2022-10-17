using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task.Dal;

namespace Task.Models
{
    public class DBEntity
    {
        private readonly Lazy<IEnumerable<Column>> _columns;
        public string Schema { get; set; }
        public string Name { get; set; }
        public Database Database { get; set; }
        public DBEntity()
        {
            _columns = new Lazy<IEnumerable<Column>>(() => RepositoryFactory.GetRepository().GetColumns(this));
        }
        public ICollection<Column> Columns { get => new List<Column>(_columns.Value); }
        public override string ToString() => $"{this.Schema}.{this.Name}";
    }
}
