using Microsoft.AspNetCore.Mvc; 
using FisherInsuranceApi.Data;
using FisherInsuranceApi.Models;

[Route("api/quotes")]

public class QuotesController : Controller
{
    private IMemoryStore db;
    public QuotesController(IMemoryStore repo) 
    { 
         db = repo; 
    }

    [HttpGet] 
    public IActionResult GetQuotes() 
    { 
        return Ok(db.RetrieveAllQuotes); 
    } 

    // POST api/quotes
    [HttpPost]
    public IActionResult Post([FromBody]Quote quote)
    {
        //return Created("", value);
        return Ok(db.CreateQuote(quote)); 
    }

    // GET api/quote/id 
    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        //return Ok("The id is: " + id);
        return Ok(db.RetrieveQuote(id)); 
    }

    // PUT api/quotes/id
    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody]Quote quote)
    {
        //return NoContent();
        return Ok(db.UpdateQuote(quote));
    }

    // DELETE api/quotes/id
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        //return Delete(id);
        db.DeleteQuote(id); 
        return Ok();
    }
}