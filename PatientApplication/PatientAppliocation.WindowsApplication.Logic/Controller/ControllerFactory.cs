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

using ZsutPw.Patterns.WindowsApplication.Model;
using ZsutPw.Patterns.WindowsApplication.Utilities;

namespace ZsutPw.Patterns.WindowsApplication.Controller
{
    public static class ControllerFactory
    {
        private static IController controller;

        public static IController GetController(IEventDispatcher dispatcher)
        {
            if (controller == null)
            {
                IModel newModel = new Model.Model(dispatcher);

                IController newController = new Controller(dispatcher, newModel);

                controller = newController;
            }

            return controller;
        }
    }
}