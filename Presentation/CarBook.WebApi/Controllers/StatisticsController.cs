using CarBook.Application.Features.Mediator.Queries.StatisticsQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StatisticsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("GetCarCount")]
        public IActionResult GetCarCount()
        {
            var values = _mediator.Send(new GetCarCountQuery());
            return Ok(values.Result);
        }
        [HttpGet("GetLocationCount")]
        public IActionResult GetLocationCount()
        {
            var values = _mediator.Send(new GetLocationCountQuery());
            return Ok(values.Result);
        }
        [HttpGet("GetAuthorCount")]
        public IActionResult GetAuthorCount()
        {
            var values = _mediator.Send(new GetAuthorCountQuery());
            return Ok(values.Result);
        }
        [HttpGet("GetBlogCount")]
        public IActionResult GetBlogCount()
        {
            var values = _mediator.Send(new GetBlogCountQuery());
            return Ok(values.Result);
        }
        [HttpGet("GetBrandCount")]
        public IActionResult GetBrandCount()
        {
            var values = _mediator.Send(new GetBrandCountQuery());
            return Ok(values.Result);
        }
        [HttpGet("GetAvgRentPriceForDaily")]
        public IActionResult GetAvgRentPriceForDaily()
        {
            var values = _mediator.Send(new GetAvgRentPriceForDailyQuery());
            return Ok(values.Result);
        }
        [HttpGet("GetAvgRentPriceForWeekly")]
        public IActionResult GetAvgRentPriceForWeekly()
        {
            var values = _mediator.Send(new GetAvgRentPriceForWeeklyQuery());
            return Ok(values.Result);
        }
        [HttpGet("GetAvgRentPriceForMonthly")]
        public IActionResult GetAvgRentPriceForMonthly()
        {
            var values = _mediator.Send(new GetAvgRentPriceForMonthlyQuery());
            return Ok(values.Result);
        }
        [HttpGet("GetCarCountByTransmissionIsAuto")]
        public IActionResult GetCarCountByTransmissionIsAuto()
        {
            var values = _mediator.Send(new GetCarCountByTransmissionIsAutoQuery());
            return Ok(values.Result);
        }
        [HttpGet("GetBrandNameByMaxCar")]
        public IActionResult GetBrandNameByMaxCar()
        {
            var values = _mediator.Send(new GetBrandNameByMaxCarQuery());
            return Ok(values.Result);
        }
        [HttpGet("GetBlogTitleByMaxBlogComment")]
        public IActionResult GetBlogTitleByMaxBlogComment()
        {
            var values = _mediator.Send(new GetBlogTitleByMaxBlogCommentQuery());
            return Ok(values.Result);
        }
        [HttpGet("GetCarCountByKmSmallerThan1000")]
        public IActionResult GetCarCountByKmSmallerThan1000()
        {
            var values = _mediator.Send(new GetCarCountByKmSmallerThan1000Query());
            return Ok(values.Result);
        }
        [HttpGet("GetCarCountByFuelGasolineOrDiesel")]
        public IActionResult GetCarCountByFuelGasolineOrDiesel()
        {
            var values = _mediator.Send(new GetCarCountByFuelGasolineOrDieselQuery());
            return Ok(values.Result);
        }
        [HttpGet("GetCarCountByFuelElectric")]
        public IActionResult GetCarCountByFuelElectric()
        {
            var values = _mediator.Send(new GetCarCountByFuelElectricQuery());
            return Ok(values.Result);
        }
        [HttpGet("GetCarBrandAndModelByRentPriceDailyMax")]
        public IActionResult GetCarBrandAndModelByRentPriceDailyMax()
        {
            var values = _mediator.Send(new GetCarBrandAndModelByRentPriceDailyMaxQuery());
            return Ok(values.Result);
        }
        [HttpGet("GetCarBrandAndModelByRentPriceDailyMin")]
        public IActionResult GetCarBrandAndModelByRentPriceDailyMin()
        {
            var values = _mediator.Send(new GetCarBrandAndModelByRentPriceDailyMinQuery());
            return Ok(values.Result);
        }
    }
}
