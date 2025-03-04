﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using CleanArchitecture.Presentation.Abstractions;
using CleanArchitecture.Application.Features.Test;


namespace CleanArchitecture.Presentation.Controllers;
public sealed class TestController : ApiController
{
    public TestController(IMediator mediator) : base(mediator)
    {
    }

    [HttpPost]
    public async Task<IActionResult> Get(TestCommand request, CancellationToken cancellationToken)
    {
        throw new Exception("sdasdasd");
        //var response = await _mediator.Send(request, cancellationToken);

        //return StatusCode(response.StatusCode, response);
    }
}
