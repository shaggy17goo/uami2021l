//===============================================================================
//
// PlaZa System Platform
//
//===============================================================================
//
// Warsaw University of Technology
// Computer Networks and Services Division
// Copyright © 2020 PlaZa Creators
// All rights reserved.
//
//===============================================================================

using System;

namespace Model.Service
{
    public static class NetworkClientFactory
    {
        public static INetwork GetNetworkClient()
        {
            
            var serviceHost = Environment.GetEnvironmentVariable("SERVICE_HOST");
            var servicePortStr =  Environment.GetEnvironmentVariable("SERVICE_PORT");
            var servicePort = int.Parse(servicePortStr ?? string.Empty);
            return new NetworkClient(serviceHost, servicePort);
     
        }
    }
}