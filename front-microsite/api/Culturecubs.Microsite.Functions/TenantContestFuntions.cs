using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using Culturecubs.Microsite.DataAccess.Models;
using Culturecubs.Microsite.DataAccess.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Attributes;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;

namespace Culturecubs.Microsite.Functions
{
    public class TenantContestFuntions
    {
        private readonly ILogger<TenantContestFuntions> _logger;
        private readonly ITenantContestRepository _tenantContestRepository;

        public TenantContestFuntions(ILogger<TenantContestFuntions> log, ITenantContestRepository tenantContestRepository)
        {
            _logger = log;
            _tenantContestRepository = tenantContestRepository;
        }

        [FunctionName("GetContestsByTenantId")]
        [OpenApiOperation(operationId: "getcontestsbytenantid", tags: new[] { "Contest" })]
        [OpenApiParameter(name: "guid", In = ParameterLocation.Path, Required = true, Type = typeof(Guid), Description = "TenantId.")]
        [OpenApiResponseWithBody(statusCode: HttpStatusCode.OK, contentType: "application/json", bodyType: typeof(List<Contest>), Description = "Returns contests based on passed TenantId")]
        public async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "contest/{guid}")] HttpRequest req, Guid guid)
        {

            try
            {
                _logger.LogInformation("Get contest by Id request Started");
                var result = await _tenantContestRepository.GetContestsByTenantId(guid);
                return new OkObjectResult(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error while processing tenant/{guid} request.");
                return new BadRequestObjectResult(Constants.ErrorMsg);
            }
        }
    }
}

