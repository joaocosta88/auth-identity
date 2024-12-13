using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1;

public class IdentityTestDbContext(DbContextOptions options) 
    : IdentityDbContext (options)
{
    
}