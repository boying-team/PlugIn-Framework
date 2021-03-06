using System;
using NHibernate.Cfg;

namespace Boying.Data
{
    public interface ISessionConfigurationCache
    {
        Configuration GetConfiguration(Func<Configuration> builder);
    }
}