using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;
using WebApplication3.Controllers;

namespace WebApplication3
{
    internal class ControllerActivator : IHttpControllerActivator
    {
        public IHttpController Create(HttpRequestMessage request, HttpControllerDescriptor controllerDescriptor, Type controllerType)
        {
            IHttpController controller;

            switch (controllerType.Name)
            {
                case nameof(HiController):
                    controller = new HiController(new HiProvider());
                    break;
                case nameof(HelloController):
                    controller = new HelloController(new HelloProvider());
                    break;
                default:
                    controller = null;//??????????/
                    break;
            }
            #region MyRegion
            //var w = controllerType.GetConstructors();
            //var s = w[0].GetParameters();
            //var t = s[0].ParameterType;
            //List<string> list = new List<string>();


            //var assemblies = AppDomain.CurrentDomain.GetAssemblies();
            //foreach (var asm in assemblies)
            //{
            //    foreach (var item in asm.GetTypes())
            //    {
            //        if (t.IsAssignableFrom(item) && item.IsClass)
            //        {
            //            list.Add(item.Name);
            //        }
            //    }
            //}

            #endregion
            return controller;
        }
    }
}