using DataEntityAndAccessLayer;
using DataEntityAndAccessLayer.Entities.Atm;
using Microsoft.EntityFrameworkCore;

namespace ServiceLayer;

public class AtmService
{
    private readonly BankDbContext _context;

    public AtmService(BankDbContext context)
    {
        _context = context;
    }

    public async Task<List<Atm>> GetAllAtms()
    {
        return await _context.Atms
            .AsNoTracking()
            .ToListAsync();
    }


}
