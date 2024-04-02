using AdminUser_WebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AdminUser_WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class AdminUserController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAll()
    {
        AdminUserContext context = new AdminUserContext();
        List<AdminUser> list = context.AdminUsers.ToList();
        return Ok(list);
    }
    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        AdminUserContext context = new AdminUserContext();
        AdminUser value = context.AdminUsers.FirstOrDefault(x => x.Id == id);
        if (value == null)
        {
            return NotFound("Value with this id could not be found.");
        }
        else
        {
            return Ok(value);
        }
    }
    [HttpPost]
    public IActionResult Post(AdminUser adminUser)
    {
        AdminUserContext context = new AdminUserContext();
        if (adminUser == null)
        {
            return NotFound("Value could not be added.");
        }
        context.AdminUsers.Add(adminUser);
        context.SaveChanges();
        return Ok(context);
    }
    [HttpPut]
    public IActionResult Put(AdminUser adminUser)
    {
        AdminUserContext context = new AdminUserContext();
        var value = context.AdminUsers.FirstOrDefault(x => x.Id == adminUser.Id);
        if (value != null)
        {
            value.Phone = adminUser.Phone;
            value.Name = adminUser.Name;
            value.Email = adminUser.Email;
            value.Surname = adminUser.Surname;
            context.AdminUsers.Update(adminUser);
            context.SaveChanges();
            return Ok(context);
        }
        else
        {
            return NotFound("Value could not be found.");
        }
    }
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        AdminUserContext context = new AdminUserContext();
        var value = context.AdminUsers.FirstOrDefault(x => x.Id == id);
        if (value != null)
        {
            context.AdminUsers.Remove(value);
            context.SaveChanges();
            return Ok(context);
        }
        else
        {
            return NotFound("Value could not be found.");
        }

    }
}
