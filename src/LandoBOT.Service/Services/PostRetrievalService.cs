using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;

namespace LandoBOT.Service
{
	internal sealed class PostRetrievalService : BackgroundService
	{
		public PostRetrievalService() {}

		protected override async Task ExecuteAsync(CancellationToken token)
		{
			await GetPosts(token);
		}

		private async Task GetPosts(CancellationToken token)
		{
			Console.WriteLine("Started process");
			await Task.Delay(500);
			Console.WriteLine("Ending process");
		}
	}
}
