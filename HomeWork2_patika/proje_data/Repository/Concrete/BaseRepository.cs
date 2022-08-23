using Microsoft.EntityFrameworkCore;
using proje_data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_data.Repository.Concrete
{
    public  class BaseRepository<Entity> : IBaseRepository<Entity> where Entity : class
    {
        protected readonly AppDbContext Context;
        private DbSet<Entity> entities;
        

        public BaseRepository(AppDbContext dbContext)
        {
            this.Context = dbContext;
            this.entities = Context.Set<Entity>();
        }

      

        public async Task<IEnumerable<Entity>> GetAllAsync()
        {
            return await entities.AsNoTracking().ToListAsync();
        }

        public async Task<Entity> GetByIdAsync(int entityId)
        {
            return await entities.Where(entity => EF.Property<int>(entity, "id").Equals(entityId)).SingleOrDefaultAsync();
        }

        public async Task InsertAsync(Entity entity)
        {
            await entities.AddAsync(entity);
        }

        public async void RemoveAsync(Entity entity)
        {
            entities.Remove(entity);
        }

        public async void Update(Entity entity)
        {
            entities.Update(entity);
        }
    }
}
