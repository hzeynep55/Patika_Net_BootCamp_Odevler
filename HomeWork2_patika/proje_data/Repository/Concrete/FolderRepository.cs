using proje_data.Context;
using proje_data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_data.Repository.Concrete
{
    public class FolderRepository:BaseRepository<Folder>,IFolderRepository
    {
        public FolderRepository(AppDbContext dbContext) : base(dbContext)
        {

        }
    }
}
