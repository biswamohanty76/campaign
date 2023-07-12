using Culturecubs.Microsite.DataAccess.Models;
using Culturecubs.Microsite.DataAccess.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Attributes;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Net;
using System.Threading.Tasks;

namespace Culturecubs.Microsite.Functions
{
    public class ThemeConfigurationFunctions
    {
        private readonly ILogger<ThemeConfigurationFunctions> _logger;
        private readonly IThemeConfigurationRepository _themeConfigurationRepository;
        public ThemeConfigurationFunctions(ILogger<ThemeConfigurationFunctions> log, IThemeConfigurationRepository themeConfigurationRepository)
        {
            _logger = log;
            _themeConfigurationRepository = themeConfigurationRepository;
        }

        [FunctionName("GetThemeByTenantId")]
        [OpenApiOperation(operationId: "getthemebytenantid", tags: new[] { "Theme" })]
        [OpenApiParameter(name: "guid", In = ParameterLocation.Path, Required = true, Type = typeof(Guid), Description = "TenantId.")]
        [OpenApiResponseWithBody(statusCode: HttpStatusCode.OK, contentType: "application/json", bodyType: typeof(ThemeConfiguration), Description = "Returns Theme based on passed TenantId")]
        public async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "theme/{guid}")] HttpRequest req, Guid guid)
        {

            try
            {
                _logger.LogInformation("Get GetThemeByTenantId request Started");
                var result = await _themeConfigurationRepository.GetThemeByTenantId(guid);
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
