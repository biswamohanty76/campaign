using CCubAPI.Data;
using CCubAPI.Tenants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Packaging.Signing;
using System.Collections.Generic;

[ApiController]
[Route("api/[controller]")]
public class TenantsController : ControllerBase
{   
    private readonly CCubAPIContext _dbContext;   
    public TenantsController( CCubAPIContext dbContext)
    {       
        _dbContext = dbContext;
    }  

    [HttpPost("addtenant")]
    public async Task<IActionResult> AddTenant(Tenant tenant)
    {     
        _dbContext.Tenant.Add(tenant);
        await _dbContext.SaveChangesAsync();     
        return CreatedAtAction(nameof(GetTenant), new { id = tenant.Id }, tenant);
    }

    [HttpGet("tenant")]
    [Authorize]
    public async Task<ActionResult<Tenant>> GetTenant(long id)
    {
        var tenant = await _dbContext.Tenant.FindAsync(id);
        if (tenant == null)
        {
            return NotFound();
        }
        return Ok(tenant);
    }
}
