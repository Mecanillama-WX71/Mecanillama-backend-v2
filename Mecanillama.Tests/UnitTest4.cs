using AutoMapper;
using Mecanillama.API.Customers.Controllers;
using Mecanillama.API.Customers.Domain.Services;
using Mecanillama.API.Customers.Domain.Model;
using Mecanillama.API.Customers.Services;
using Mecanillama.API.Reviews.Controllers;
using Moq;

namespace Mecanillama.Tests;

public class UnitTest4
{
    
    private readonly ReviewsController _controller;

    public UnitTest4()
    {
        _controller = new ReviewsController(null, null);
    }

    [Fact]
    public async Task Test4()
    {
        var response = _controller.GetAllSync();
        Assert.NotNull(response);
    }
}