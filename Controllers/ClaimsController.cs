using Microsoft.AspNetCore.Mvc; 

using FisherInsuranceApi.Models;

using FisherInsuranceApi.Data;

[Route("api/claims")] 

public class ClaimsController : Controller 
{
    private IMemoryStore db;
    public ClaimsController(IMemoryStore repo)
    {
        db = repo;
    }
    
    // POST 
    [HttpPost] 
    public IActionResult Post([FromBody]Claim Claim) 
    {
         return Ok(db.CreateClaim(Claim));
    }

    // GET
    [HttpGet("{id}")] 
    public IActionResult Get(int id) 
    {
         return Ok(db.RetrieveClaim(id));
    }

    // PUT
    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody]Claim Claims) 
    {
         return Ok(db.UpdateClaim(Claims)); 
    }

    // DELETE
    [HttpDelete("{id}")] 
    public IActionResult Delete(int id) 
    {
         db.DeleteClaim(id);
         return Ok(); 
    }

    [HttpGet]
    public IActionResult GetClaimss()
    {
        return Ok(db.RetrieveAllClaims);
    } 
}

