using Metrics.InfluxDB.Model;
using System;

namespace Metrics.InfluxDB.SamplesConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var influxConfig = new InfluxConfig() { Hostname = "172.22.0.17", Port = 8086, Database = "metrics", Username = "admin", Password = "admin" };  
            Metric.Config
                .WithReporting(config => config
                    .WithInfluxDbHttp(influxConfig, TimeSpan.FromSeconds(10)));
            Console.ReadLine();
        }
    }
}
