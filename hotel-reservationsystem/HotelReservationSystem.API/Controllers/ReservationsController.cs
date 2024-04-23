using HotelReservationSystem.Data;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Cryptography;

namespace HotelReservationSystem.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ReservationsController : ControllerBase
{
    // GET: api/Reservations
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return [];
    }

    // GET: api/Reservations/ReservationID
    [HttpGet("{reservationId}", Name = "Get")]
    public CustomerReservation Get(int reservationId)
    {
        // Pretend to do some work
        Thread.SpinWait(int.MaxValue / 500);

        // Return dummy data
        return new CustomerReservation
        {
            ReservationID = reservationId,

            CustomerID = $"{new Random().Next()}",

            HotelID = $"Hotel {new Random().Next()}",

            CheckIn = DateTime.Now.AddDays(10),

            CheckOut = DateTime.Now.AddDays(10 + new Random().NextDouble() * 100),

            NumberOfGuests = new Random().Next(5) + 1,

            ReservationComments = GetRandomString(new Random().Next(1000))
        };
    }

    // POST: api/Reservations
    [HttpPost]
    public void Post([FromBody] string value)
    {
        // Pretend to do some work
        Thread.SpinWait(int.MaxValue / 100);

        Debug.WriteLine($"PUT: - Value: {value}");
    }

    // PUT: api/Reservations/ReservationID
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
        // Pretend to do some work
        Thread.SpinWait(int.MaxValue / 100);

        Debug.WriteLine($"PUT: - Value: {value} - Id: {id}");

    }

    // DELETE: api/ApiWithActions/ReservationID
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
        // Pretend to do some work
        Thread.SpinWait(int.MaxValue / 50);

        Debug.WriteLine($"PUT: - Id: {id}");
    }

    private static string GetRandomString(int stringLength)
    {
        using var rng = RandomNumberGenerator.Create();

        var byteCount = (int)Math.Ceiling((double)(stringLength * 6) / 8);
        var bytes = new byte[byteCount];
        rng.GetBytes(bytes);

        return Convert.ToBase64String(bytes);
    }
}
