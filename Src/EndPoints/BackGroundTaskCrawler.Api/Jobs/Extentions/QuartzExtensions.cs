using Quartz;

namespace BackGroundTaskCrawler.EndPoints.Api.Jobs.Extentions;

public static class QuartzExtensions
{
    public static void AddJobAndTrigger<T>(this IServiceCollectionQuartzConfigurator quartz, IConfiguration configuration) where T : IJob
    {
        string jobName = typeof(T).Name;

        var configKey = $"Jobs:{jobName}:Cron";
        var cronSchedule = configuration[configKey];

        if (string.IsNullOrEmpty(cronSchedule))
            throw new Exception("no cron schedule is configure");

        var jobKey = new JobKey(jobName);

        quartz.AddJob<T>(config => config.WithIdentity(jobKey));

        quartz.AddTrigger(config => config
        .ForJob(jobKey)
        .WithIdentity($"{jobName}-trigger")
        .WithCronSchedule(cronSchedule));
    }
}
