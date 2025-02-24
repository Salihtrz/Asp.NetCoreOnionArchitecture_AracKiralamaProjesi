using CarBook.Application.Features.Mediator.Commands.ReviewCommands;
using CarBook.Application.Features.Mediator.Queries.LocationQueries;
using CarBook.Application.Features.Mediator.Queries.ReviewQueries;
using CarBook.Application.Validators.ReviewValidators;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ReviewsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> ReviewListByCarId(int id)
        {
            //Handler tarafında IRequestHandler<İstek,Yanıt> bu yapıya yazdığımız değerlere göre istek ve yanıt alıyoruz.
            var values = await _mediator.Send(new GetReviewByCarIdQuery(id));//Send metodunun içinde neye istek atacağımızı yazdık.
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateReview(CreateReviewCommand createReviewCommand)
        {
            CreateReviewValidator validators = new CreateReviewValidator();
            var validationResult = validators.Validate(createReviewCommand);
            if(validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors);
            }
            await _mediator.Send(createReviewCommand);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateReview(UpdateReviewCommand updateReviewCommand)
        {
            await _mediator.Send(updateReviewCommand);
            return Ok();
        }
    }
}
