using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;

namespace LandoBOT.Service
{
	internal sealed class PostRetrievalService : BackgroundService
	{
		private readonly BotConfig _config;

		public PostRetrievalService(BotConfig config) 
		{
			_config = config;
		}

		protected override async Task ExecuteAsync(CancellationToken token)
		{
			await GetPosts(token);
		}

		private async Task GetPosts(CancellationToken token)
		{
			var user = _config.Username;
			Console.WriteLine($"Username: {user}");
			Console.WriteLine("Started process");
			await Task.Delay(500);
			Console.WriteLine("Ending process");
		}
	}
}
