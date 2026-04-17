using AnkiCardGenerator.Api.DTOs;
using AnkiCardGenerator.Api.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AnkiCardGenerator.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CardsController : ControllerBase
    {
        private readonly ICardService _cardService;

        public CardsController(ICardService cardService)
        {
            _cardService = cardService;
        }

        [HttpPost("generate")]
        public IActionResult Generate([FromBody] GenerateCardsRequestDto request)
        {
            var result = _cardService.GenerateCards(request);
            return Ok(result);
        }
    }
}
