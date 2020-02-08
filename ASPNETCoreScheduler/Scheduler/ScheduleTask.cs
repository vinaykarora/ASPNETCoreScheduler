using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Threading.Tasks;

namespace ASPNETCoreScheduler.Scheduler
{
    public class ScheduleTask : ScheduledProcessor
    {
        public ScheduleTask(IServiceScopeFactory serviceScopeFactory,
            IOptions<ScheduleTaskSettings> settings) : base(serviceScopeFactory, settings)
        {
          
        }

        protected override string Schedule => Settings.PrimaryOrderTaskSchedule;

        public override Task ProcessInScope(IServiceProvider serviceProvider)
        {
            Console.WriteLine("Processing starts here");
            return Task.CompletedTask;
        }
    }
}
