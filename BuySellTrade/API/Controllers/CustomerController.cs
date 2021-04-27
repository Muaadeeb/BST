using DataLibrary.Data;
using DataLibrary.Db.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{

    //TODO: fix this later.  
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        //private readonly ICustomerData _customerData;

        //public CustomerController(ICustomerData customerData)
        //{
        //    _customerData = customerData;
        //}

        //[HttpPost]
        //[ValidateModel]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        //public async Task<IActionResult> UpdateCustomer(CustomerModel customer)
        //{


        //    var customer = await _customerData.GetCustomer();

        //    customer.
            
            
        //    return null;
        //}


    }
}
