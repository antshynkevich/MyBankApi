﻿using AutoMapper;
using DataEntityAndAccessLayer;
using DataEntityAndAccessLayer.Entities.Atm;
using Microsoft.EntityFrameworkCore;

namespace ServiceLayer;

public class AtmService
{
    private readonly BankDbContext _context;
    private readonly IMapper _mapper;

    public AtmService(BankDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<List<Atm>> GetAllAtms()
    {
        return await _context.Atms
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task AddAtmsToDb(JsonAutogeneratedClass data)
    {
        var atmsArray = data.Data.ATM;
        var atmsMapToDb = _mapper.Map<Atm[]>(atmsArray);
        await _context.Atms.AddRangeAsync(atmsMapToDb);
        await _context.SaveChangesAsync();
    }
}
