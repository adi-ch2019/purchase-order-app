using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace adi.ch.dev.poa.api.Controllers;

[ApiController]
[Route("[controller]")]

public class OrderController : ControllerBase
{


    private readonly ILogger<OrderController> _logger;

    public OrderController(ILogger<OrderController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "OrdersGet")]
    public IActionResult Get()
    {
       IList<OrderModel> Orders =new List<OrderModel>();
        for (int i=0;i<5;i++)
        {
            OrderModel om =new OrderModel();
            om.OrderDate = Convert.ToDateTime("31/08/2023").AddDays(i).Date;
            om.Quantity=i;
            om.Details="Details -"+i;
            om.Price=i*1.01;
            Orders.Add(om);
        }

        return Ok(Orders);

    }
}
