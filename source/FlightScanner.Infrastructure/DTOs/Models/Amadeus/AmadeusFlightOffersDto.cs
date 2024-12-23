﻿using System.Text.Json.Serialization;

namespace FlightScanner.Infrastructure.DTOs.Models.Amadeus;

public class AmadeusFlightOffersDto
{
    [JsonPropertyName("source")]
    public string SourceOfTheFlightOffer { get; set; } = null!;

    [JsonPropertyName("oneWay")]
    public bool OneWay { get; set; }

    [JsonPropertyName("numberOfBookableSeats")]
    public int NumberOfBookableSeats { get; set; }

    [JsonPropertyName("itineraries")]
    public IEnumerable<AmadeusFlightRouteDto> FlightRoutes { get; set; } = null!;

    [JsonPropertyName("price")]
    public AmadeusFlightOfferPriceDto Price { get; set; } = null!;
}
