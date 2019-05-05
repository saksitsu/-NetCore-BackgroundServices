using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace NETCoreBackgroundService.BackgroundServices.Tasks
{
    public class Task2 : IScheduledTask
    {
        public string Schedule => "*/1 * * * *";
        Class.Resource cls = new Class.Resource();

        public Task2(IServiceScopeFactory scopeFactory)
        {
        }
        public async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            cls.WriteFile("Task2.txt");
            await Task.Delay(1000, stoppingToken); //1 seconds delay
        }
    }
}
