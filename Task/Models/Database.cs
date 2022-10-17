using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Dal;

namespace Task.Models
{
    public class Database
    {
        private readonly Lazy<IEnumerable<DBEntity>> _tables;
        private readonly Lazy<IEnumerable<DBEntity>> _views;
        private readonly Lazy<IEnumerable<Procedure>> _procedures;
        public string Name { get; set; }
        public Database()
        {
            _tables = new Lazy<IEnumerable<DBEntity>>(() => RepositoryFactory.GetRepository().GetDBEntities(this, DBEntityType.Table));
            _views = new Lazy<IEnumerable<DBEntity>>(() => RepositoryFactory.GetRepository().GetDBEntities(this, DBEntityType.View));
            _procedures = new Lazy<IEnumerable<Procedure>>(() => RepositoryFactory.GetRepository().GetProcedures(this));
        }
        public ICollection<DBEntity> Tables { get => new List<DBEntity>(_tables.Value); }
        public ICollection<DBEntity> Views { get => new List<DBEntity>(_views.Value); }
        public ICollection<Procedure> Procedures { get => new List<Procedure>(_procedures.Value); }
        public override string ToString() => Name;
    }
}
