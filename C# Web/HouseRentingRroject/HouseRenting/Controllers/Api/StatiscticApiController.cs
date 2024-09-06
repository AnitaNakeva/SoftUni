using HouseRenting.Contracts;
using HouseRenting.Models.Statistic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HouseRenting.Controllers.Api
{
        [Route("api/statistics")]
        [ApiController]
        public class StatisticApiController : ControllerBase
        {
            private readonly IStatisticsService _statistics;

            public StatisticApiController(IStatisticsService statistics)
            {
                _statistics = statistics;
            }

            [HttpGet]
            public StatisticServiceModel GetStatistic()
            {
                return _statistics.Total();
            }
        }
    }

