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
            
            string serviceHost = Environment.GetEnvironmentVariable("SERVICE_HOST");
            string servicePortStr =  Environment.GetEnvironmentVariable("SERVICE_PORT");
            int servicePort = int.Parse(servicePortStr);
            return new NetworkClient(serviceHost, servicePort);
     
        }
    }
}