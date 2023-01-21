using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using XtraCourses.Infrastructure.Helpers;
using XtraCourses.Infrastructure.services;

namespace XtraCourses.Infrastructure.Persistence
{
    internal sealed class DatabaseInitializer : IHostedService
    {
        private readonly IServiceProvider _serviceProvider;
        //private readonly XtraDataClient _dataClient;

        public DatabaseInitializer(IServiceProvider serviceProvider/*, XtraDataClient dataClient*/)
        {
            _serviceProvider = serviceProvider;
            //_dataClient = dataClient;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            using var scope = _serviceProvider.CreateScope();
            var dbContext = scope.ServiceProvider.GetRequiredService<DataContext>();
            await dbContext.Database.MigrateAsync(cancellationToken);

            if(await dbContext.Users.AnyAsync(cancellationToken))
                return;

            //var inputProjects = await _dataClient.GetProjectsData();

            //    var result = XtraResponseMapping.MapExtraResponse(inputProjects);

            //    await dbContext.Users.AddRangeAsync(result.Item1, cancellationToken);
            //    await dbContext.Courses.AddRangeAsync(result.Item2, cancellationToken);
            //    await dbContext.Projects.AddRangeAsync(result.Item3, cancellationToken);
        }

        public Task StopAsync(CancellationToken cancellationToken) => Task.CompletedTask;
    }
}
