using GameStop.DAL;
using GameStop.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStop.Services
{
    public class LayoutServices : ILayoutServices
    {
        private readonly AppDbContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public LayoutServices(AppDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<Dictionary<string, string>> GetSettingsAsync()
        {
            return await _context.Settings.
                ToDictionaryAsync(s => s.Key, s => s.Value);
        }
    }
}
