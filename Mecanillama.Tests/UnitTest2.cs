using AutoMapper;
using Mecanillama.API.Appointments.Controllers;
using Mecanillama.API.Customers.Controllers;
using Mecanillama.API.Customers.Domain.Services;
using Mecanillama.API.Customers.Domain.Model;
using Mecanillama.API.Customers.Services;
using Moq;

namespace Mecanillama.Tests;

public class UnitTest2
{
    
    private readonly AppointmentsController _controller;

    public UnitTest2()
    {
        _controller = new AppointmentsController(null, null);
    }

    [Fact]
    public async Task Test2()
    {
        var response = _controller.GetAllAsync();
        Assert.NotNull(response);
    }
}