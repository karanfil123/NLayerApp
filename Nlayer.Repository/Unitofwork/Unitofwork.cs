using Nlayer.Core.Unitofwork;

namespace Nlayer.Repository.Unitofwork
{
    public class Unitofwork : IUnitofwork
    {
        readonly private AppDbContext _context;

        public Unitofwork(AppDbContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
