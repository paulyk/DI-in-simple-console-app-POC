using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using DITest;
using Microsoft.Extensions.Hosting;

internal class MyService : IHostedService {

    public MyService(ShipService ship)  // injected stuff
    {
        ship.ShipIt();
    }

    public Task StartAsync(CancellationToken cancellationToken) {
        Console.WriteLine("Starting service");
        return Task.Delay(100);
    }

    public Task StopAsync(CancellationToken cancellationToken) {
        Console.WriteLine("Stop service");
        return Task.CompletedTask;
    }
}