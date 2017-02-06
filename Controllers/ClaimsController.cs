[Route("api/claim/myclaims")]

    public class AutoController : Controller
    {
        // POST api/claim/myclaims 
        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            return Created("", value);
        }

        // GET api/claim/myclaims/id 
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok("The id is: " + id);
        }

        // PUT api/claim/myclaims/id
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]string value)
        {
            return NoContent();
        }

        // DELETE api/claim/myclaims/id
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Delete(id);
        }
    }