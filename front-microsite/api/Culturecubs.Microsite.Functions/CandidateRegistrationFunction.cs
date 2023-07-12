using System;
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
    public class CandidateRegistrationFunction
    {
        private readonly ILogger<CandidateRegistrationFunction> _logger;
        private readonly ICanidateRegistrationRepository _canidateRegistrationRepository;

        public CandidateRegistrationFunction(ILogger<CandidateRegistrationFunction> log, ICanidateRegistrationRepository canidateRegistrationRepository)
        {
            _logger = log;
            _canidateRegistrationRepository = canidateRegistrationRepository;
        }

        [FunctionName("CandidateRegistration")]
        [OpenApiOperation(operationId: "candidateregistration", tags: new[] { "Candidate" })]
        [OpenApiRequestBody("application/json", typeof(CandidateRegistration), Description = "Json request body containing candidate model details")]
        [OpenApiResponseWithBody(statusCode: HttpStatusCode.OK, contentType: "application/json", bodyType: typeof(string), Description = "Register a new Candiate and return boolean value  true in success.")]
        public async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = "candidate")] HttpRequest req)
        {
            try
            {
                _logger.LogInformation("Registering Candidate Started");
                var content = await new StreamReader(req.Body).ReadToEndAsync();
                var requestBody = JsonConvert.DeserializeObject<CandidateRegistration>(content);
                var response = await _canidateRegistrationRepository.RegisterCanidate(requestBody);
                if (response)
                    _logger.LogInformation("Canidate Registerd successfully!!");
                return new OkObjectResult(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while processing CandidateRegistration request.");
                return new BadRequestObjectResult(Constants.ErrorMsg);
            }
        }
    }
}

