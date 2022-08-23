using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_data.UnitOfWork
{
    public interface IUnitOfWork
    {
        public interface IUnitOfWork : IDisposable
        {
            Task CompleteAsync();
        }

        Task CompleteAsync();
    }
}
