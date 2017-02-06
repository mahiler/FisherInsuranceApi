[Route("api/homeinsurance/quote")]

    public class HomeController : Controller
    {
        // POST api/homeinsurance/quote 
        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            return Created("", value);
        }

        // GET api/homeinsurance/quote/id 
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok("The id is: " + id);
        }

        // PUT api/homeinsurance/quote/id
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]string value)
        {
            return NoContent();
        }

        // DELETE api/homeinsurance/quote/id
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Delete(id);
        }
    }