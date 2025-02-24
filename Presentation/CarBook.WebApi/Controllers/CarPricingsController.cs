using CarBook.Application.Features.Mediator.Queries.CarPricingQueries;
using CarBook.Application.Features.Mediator.Queries.LocationQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarPricingsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CarPricingsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetCarPricingsWithCarList()
        {
            //Handler tarafında IRequestHandler<İstek,Yanıt> bu yapıya yazdığımız değerlere göre istek ve yanıt alıyoruz.
            var values = await _mediator.Send(new GetCarPricingWithCarQuery());//Send metodunun içinde neye istek atacağımızı yazdık.
            return Ok(values);
        }
        [HttpGet("GetCarPricingWithTimePeriodList")]
        public async Task<IActionResult> GetCarPricingWithTimePeriodList()
        {
            //Handler tarafında IRequestHandler<İstek,Yanıt> bu yapıya yazdığımız değerlere göre istek ve yanıt alıyoruz.
            var values = await _mediator.Send(new GetCarPricingWithTimePeriodQuery());//Send metodunun içinde neye istek atacağımızı yazdık.
            return Ok(values);
        }
    }
}
