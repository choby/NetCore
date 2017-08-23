using System;
namespace Inman.Infrastructure.IOC
{
    public interface IEngine : IServiceProvider
    {

        /// <summary>
        /// Initialize components and plugins in the nop environment.
        /// </summary>
        /// <param name="config">Config</param>
        void Initialize();

    
    }
}
