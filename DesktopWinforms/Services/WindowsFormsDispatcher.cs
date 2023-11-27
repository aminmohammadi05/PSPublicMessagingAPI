using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopWinforms.Services
{
    public class WindowsFormsDispatcher : IDispatcher
    {
        /// <inheritdoc/>
        public DispatcherType DispatcherType { get; }

        /// <summary>
        /// Creates a new <see cref="WpfDispatcher"/> with the specified flags.
        /// </summary>
        /// <param name="dispatcherType">A set of <see cref="DispatcherType"/> flags indicating whether this <see cref="IDispatcher"/> manages special kinds of threads, which can (and should) be utilized in scenarios such as updating UI elements from code.</param>
        public WindowsFormsDispatcher(DispatcherType dispatcherType = DispatcherType.Main)
        {
            DispatcherType = dispatcherType;
        }

        /// <inheritdoc/>
        public async Task RunAsync(Action execute)
        {
            execute();
        }

        /// <inheritdoc/>
        public async Task<T> RunAsync<T>(Func<T> execute)
        {
            return execute();
        }

        /// <inheritdoc/>
        public async Task RunAsync(Func<Task> execute)
        {
            await execute();
        }

        /// <inheritdoc/>
        public async Task<T> RunAsync<T>(Func<Task<T>> execute)
        {
            return await execute();
        }

        public void Run(Action execute)
        {
            execute();
        }
    }
}
