﻿
namespace FlightsScanner.Application.Services.Contracts;

public interface IAmadeusAuthorizatoinHandlerService
{
    Task<string> GetAuthorizationTokenAsync(bool searchCachedToken);
}