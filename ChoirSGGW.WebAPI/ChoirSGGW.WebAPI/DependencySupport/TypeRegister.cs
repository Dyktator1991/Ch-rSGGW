using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChoirSGGW.WebAPI.DependencySupport
{
    public class TypeRegister : ChoirSGGW.WebAPI.DependencySupport.ITypeRegister
    {
        private readonly UnityContainer unityContainer;

        public TypeRegister()
        {
            unityContainer = new UnityContainer();        
        }

        public IUnityContainer BuildUnityContainer()
        {
            new ChoirSGGW.Domain.DependencySupport.RegisterTypes(unityContainer).BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(unityContainer));

            return unityContainer;
        }
    }
}