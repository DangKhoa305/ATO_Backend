﻿using AutoMapper;
using Azure;
using Data.DTO.Request;
using Data.DTO.Respone;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.ShipAddressSer;
using Service.ShippingSer;

namespace ATO_API.Controllers.Tourist
{
    [Route("api/tourist/shipp-address")]
    [ApiController]
    [Authorize(Roles = "Tourists")]
    public class ShipAddressController : ControllerBase
    {
        private readonly IShipAddressService _shipAddressService;
        private readonly IShippingService _shippingService;
        private readonly IMapper _mapper;
        public ShipAddressController(IShipAddressService shipAddressService, IMapper mapper, IShippingService shippingService)
        {
            _shipAddressService = shipAddressService;
            _mapper = mapper;
            _shippingService = shippingService;
        }

        [HttpGet("list-ship-addresses")]
        public async Task<ActionResult<List<ShipAddressRespone>>> GetShipAddresses()
        {
            try
            {
                var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;

                var addresses = await _shippingService.GetShipAddresses(Guid.Parse(userId));

                return Ok(addresses);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("ship-address-details/{shipAddressId}")]
        public async Task<ActionResult<ShipAddressRespone>> GetShipAddressDetails(Guid shipAddressId)
        {
            try
            {
                var address = await _shippingService.GetShipAddressDetails(shipAddressId);

                if (address == null)
                    return NotFound("Shipping address not found");

                return Ok(address);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<bool>> AddShipAddress([FromBody] ShipAddressRequest shipAddress)
        {
            try
            {
                var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
                ShipAddress responseResult = _mapper.Map<ShipAddress>(shipAddress);
                responseResult.AccountId = Guid.Parse(userId);
                var result = await _shipAddressService.AddShipAddress(responseResult);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{shipAddressId}")]
        public async Task<ActionResult<bool>> UpdateShipAddress(Guid shipAddressId, [FromBody] ShipAddressRequest shipAddress)
        {
            try
            {
                ShipAddress responseResult = _mapper.Map<ShipAddress>(shipAddress);
                var result = await _shipAddressService.UpdateShipAddress(shipAddressId, responseResult);
                if (!result)
                    return NotFound("Shipping address not found");

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
