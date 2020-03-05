using System;

namespace NorthWind.API.Attributes
{
    [NoIoCFluentRegistration]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
    public sealed class NoIoCFluentRegistration : Attribute
    {

    }
}