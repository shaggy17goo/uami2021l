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

namespace ZsutPw.Patterns.WindowsApplication.Utilities
{
    public interface IEventDispatcher
    {
        void Dispatch(Action eventAction);
    }
}