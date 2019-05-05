using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace NETCoreBackgroundService.BackgroundServices.Tasks
{
    public class Task1 : IScheduledTask
    {
        public string Schedule => "*/1 * * * *";
        Class.Resource cls = new Class.Resource();

        public Task1(IServiceScopeFactory scopeFactory)
        {
        }
        public async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            cls.WriteFile("Task1.txt");
            await Task.Delay(1000, stoppingToken); //1 seconds delay
        }

    }
}
