using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseApiController : ControllerBase
    {
        // Private field to hold the IMediator instance
        private IMediator? _mediator;

        // Protected property to access the IMediator instance 
        // If the meditator instance is not already created, it will be created here
        // If the instance is not found in the service collection, an exception will be thrown
        protected IMediator Mediator => 
        _mediator ??= HttpContext.RequestServices.GetService<IMediator>() 
            ?? throw new InvalidOperationException("Mediator not found in the service provider.");
    }
}
