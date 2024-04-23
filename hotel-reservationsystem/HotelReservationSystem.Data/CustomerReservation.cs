namespace HotelReservationSystem.Data;

[Serializable]
public class CustomerReservation
{
    public int ReservationID { get; set; }

    public string CustomerID { get; set; } = string.Empty;

    public string HotelID { get; set; } = string.Empty;

    public DateTime CheckIn { get; set; }

    public DateTime CheckOut { get; set; }

    public int NumberOfGuests { get; set; }

    public string ReservationComments { get; set; } = string.Empty;

    public override string ToString() => $"Reservation {ReservationID}, CustomerID {CustomerID}, HotelID {HotelID}, CheckIn {CheckIn:d}, CheckOut {CheckOut:d}, Guests {NumberOfGuests}\nComments: {ReservationComments}";
}