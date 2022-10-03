using Microsoft.AspNetCore.Mvc;
using FeedBackForm.Models;

namespace FeedBackForm.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FeedBackFormController : ControllerBase
{
   

    private readonly ILogger<FeedBackFormController> _logger;

    private readonly FeedBack_DbContext _DbContext;

    public FeedBackFormController(ILogger<FeedBackFormController> logger,FeedBack_DbContext dbContext)
    {
        _logger = logger;
        _DbContext=dbContext;
    }


    [HttpGet()]
    public IActionResult GetAllForm()
    {
        var feedback=this._DbContext.Feedbacks.ToList();
        return Ok(feedback);
    }

    [HttpGet("{id}")]
    public IActionResult GetFormById(int id)
    {
        var feedback=this._DbContext.Feedbacks.FirstOrDefault(o=> o.Id==id);
        return Ok(feedback);
    }


    [HttpDelete("{id}")]
    public IActionResult deleteFormById(int id)
    {
        var feedback=this._DbContext.Feedbacks.FirstOrDefault(o=> o.Id==id);
        if(feedback!=null)
        {
        this._DbContext.Remove(feedback);
        this._DbContext.SaveChanges();
        return Ok(true);
        }
        return Ok(false);
    }

     [HttpPost()]
    public IActionResult CreateFeedBack([FromBody] Feedback _feedback)
    {
        
        this._DbContext.Feedbacks.Add(_feedback);
        this._DbContext.SaveChanges();
        
        return  Ok(true);
    }


    private bool FeedBackDetailExists(int id)
        {
            return this._DbContext.Feedbacks.Any(e => e.Id == id);
        }
}
