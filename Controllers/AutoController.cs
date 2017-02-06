[Route("api/auto/quote")]

    public class AutoController : Controller
    {
        // POST api/auto/quote
        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            return Created("", value);
        }

        // GET api/auto/quote/id 
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok("The id is: " + id);
        }

        // PUT api/auto/quote/id
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]string value)
        {
            return NoContent();
        }

        // DELETE api/auto/quote/id
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Delete(id);
        }
    }