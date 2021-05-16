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

namespace ZsutPw.Patterns.WindowsApplication.Model
{
    public static class NetworkClientFactory
    {
        public static INetwork GetNetworkClient()
        {
            
            const string serviceHost = "localhost";
            const int servicePort = 8084;// 8084;

            return new NetworkClient(serviceHost, servicePort);
     
        }
    }
}