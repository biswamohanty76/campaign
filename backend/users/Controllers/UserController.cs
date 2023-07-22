using CCubAPI.Configuration;
using CCubAPI.Data;
using CCubAPI.Tenants;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Packaging.Signing;
using System.Collections.Generic;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{   
    private readonly CCubAPIContext _dbContext;   
    public UserController( CCubAPIContext dbContext)
    {       
        _dbContext = dbContext;
    } 

    [HttpGet("user")]
    public async Task<ActionResult<Tenant>> GetUser(int userid)
    {
        var user = await _dbContext.Tenant.FindAsync(userid);
        if (user == null)
        {
            return NotFound();
        }
        return Ok(user);
    }


    [HttpPost("adduser")]
    public async Task<IActionResult> AddUser(User user)
    {
        if (user == null)
            return BadRequest();
        if (string.IsNullOrEmpty(user.Password))
            return Content("TMK: Password field can't be empty ");
        user.Password = Helper.ProcessUserData(user.Password);

        _dbContext.User.Add(user);
        await _dbContext.SaveChangesAsync();
        return CreatedAtAction(nameof(GetUser), new { id = user.UserId }, user);
    }


    [HttpPost("get_alluser_by_tenantid")]
    public async Task<IActionResult> GetUsersByTenantId(List<long> user)
    {
        List<User> users = await _dbContext.User.Where(u => user.Contains(u.TenantId)).ToListAsync();       
        return Ok(users);
    }
    [HttpGet("get_by_username")]
    public async Task<User?> GetUsersByUserName(string userName)
    {
        User? users = await _dbContext.User.Where(u => u.UserName == userName).FirstOrDefaultAsync();

        return users;
    }
    [HttpPost("login")]
    public async Task<IActionResult> Login(Userlogin userLogin)
    {
        if (string.IsNullOrEmpty(userLogin.UserName) || string.IsNullOrEmpty(userLogin.Password))
            return Content("UserName Or Password cannot be empty");
        var user = await GetUsersByUserName(userLogin.UserName);
       var verify =  Helper.VerifyUserPassword(userLogin.Password, user?.Password);
        return Ok(user);
    }

}
