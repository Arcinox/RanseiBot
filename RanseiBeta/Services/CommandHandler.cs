using Discord.Commands;
using Discord.WebSocket;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RanseiBeta
{
    //public class ServiceLocator : IServiceProvider
    //{
    //    public object GetService(Type serviceType)
    //    {
    //        if (serviceType == typeof(IDiceRoller))
    //        {
    //            return new DiceRoller();
    //        }
    //        else
    //        {
    //            return null;
    //        }
    //    }
    //}

    public class CommandHandler
    {
        //private readonly IConfiguration _config;
        private readonly DiscordSocketClient _client;
        private readonly CommandService _commandService;
        private readonly IServiceProvider _services;

        public CommandHandler(IServiceProvider services)
        {
            //_config = services.GetRequiredServices<IConfiguration>();
            _commandService = services.GetRequiredService<CommandService>();
            _client = services.GetRequiredService<DiscordSocketClient>();
            _services = services;
        }

        public async Task InitialiseAsync()
        {
            await _commandService.AddModulesAsync(Assembly.GetEntryAssembly(), _services);
            /// _commandService.CommandExecuted += CommandExecutedAsync;
            _client.MessageReceived += HandleCommandAsync;
        }

        private async Task HandleCommandAsync(SocketMessage msg)
        {
            //ignore messages sent by the system
            SocketUserMessage message = msg as SocketUserMessage;
            if (message == null)
            {
                return;
            }

            int prefixPosition = 0;

            if (!message.HasStringPrefix("r!", ref prefixPosition, StringComparison.OrdinalIgnoreCase) || message.HasMentionPrefix(_client.CurrentUser, ref prefixPosition) || message.Author.IsBot)
            {
                return;
            }

            SocketCommandContext context = new SocketCommandContext(_client, message);

            // execute the command

            IResult result = await _commandService.ExecuteAsync(context, prefixPosition, _services);
        } 
    }
}
