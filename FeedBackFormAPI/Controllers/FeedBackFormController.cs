using Microsoft.AspNetCore.Mvc;
using FeedBackForm.Models;
using FeedBackForm.Dto;
using FeedBackForm.Interfaces;
using AutoMapper;

namespace FeedBackForm.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FeedBackFormController : ControllerBase
{
   

       private readonly ILogger<FeedBackFormController> _logger;

   private readonly IFeedBackRepository _feedBackRepository;
       
        private readonly IMapper _mapper;



  public FeedBackFormController(IFeedBackRepository feedBackRepository,
            IMapper mapper)
        {
            _feedBackRepository = feedBackRepository;
            _mapper = mapper;
        }


    [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Feedback>))]
        public IActionResult GetFeedBacks()
        {
            var pokemons = _mapper.Map<List<FeedBackDto>>(_feedBackRepository.GetFeedbacks());

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(pokemons);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(200, Type = typeof(Feedback))]
        [ProducesResponseType(400)]
        public IActionResult GetFeedback(int id)
        {
            if (!_feedBackRepository.FeedBackExists(id))
                return NotFound();

            var feedback = _mapper.Map<FeedBackDto>(_feedBackRepository.GetFeedback(id));

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(feedback);
        }


        [HttpPost]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public IActionResult CreateFeedBack( [FromBody] FeedBackDto feedBack)
        {
            if (feedBack == null)
                return BadRequest(ModelState);

            

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var pokemonMap = _mapper.Map<Feedback>(feedBack);

      
            if (!_feedBackRepository.CreateFeedBack(pokemonMap))
            {
                ModelState.AddModelError("", "Something went wrong while savin");
                return StatusCode(500, ModelState);
            }

            return Ok(true);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public IActionResult UpdateFeedBack(int id,
            [FromBody] FeedBackDto feedBack)
        {
            if (feedBack == null)
                return BadRequest(ModelState);

            if (id != feedBack.Id)
                return BadRequest(ModelState);

            if (!_feedBackRepository.FeedBackExists(id))
                return NotFound();

            if (!ModelState.IsValid)
                return BadRequest();

            var feedbackMap = _mapper.Map<Feedback>(feedBack);

            if (!_feedBackRepository.UpdateFeedBack(feedbackMap))
            {
                ModelState.AddModelError("", "Something went wrong updating owner");
                return StatusCode(500, ModelState);
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public IActionResult DeleteFeedBack(int id)
        {
            if (!_feedBackRepository.FeedBackExists(id))
            {
                return NotFound();
            }

       
            var feedbackToDelete = _feedBackRepository.GetFeedback(id);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

         

            if (!_feedBackRepository.DeleteFeedBack(feedbackToDelete))
            {
                ModelState.AddModelError("", "Something went wrong deleting owner");
            }

            return NoContent();
        }
}
