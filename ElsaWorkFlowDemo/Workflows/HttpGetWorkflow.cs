using Elsa;
using Elsa.Activities.Http;
using Elsa.ActivityResults;
using Elsa.Attributes;
using Elsa.Builders;
using Elsa.Services;
using Elsa.Services.Models;

namespace ElsaWorkFlowDemo.Workflows
{
    [Activity(
       Category = "HTTP",
       DisplayName = "HTTP GET Workflow",
       Description = "A simple HTTP GET workflow.")]
    public class HttpGetWorkflow : IWorkflow
    {
        public void Build(IWorkflowBuilder builder)
        {
            builder
                .StartWith<HttpEndpoint>(setup => setup
                    .WithPath("/my-get-endpoint"))
                .Then<WriteHttpResponse>(setup => setup
                    .WithStatusCode(System.Net.HttpStatusCode.OK)
                    .WithContent(context => "Hello from Elsa!"));
        }
    }
}
