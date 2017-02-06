[Route("api/life/quote")]

    public class LifeController : Controller
    {
        // POST api/life/quote 
        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            return Created("", value);
        }

        // GET api/life/quote/id 
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok("The id is: " + id);
        }

        // PUT api/life/quote/id
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]string value)
        {
            return NoContent();
        }

        // DELETE api/life/quote/id
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Delete(id);
        }
    }