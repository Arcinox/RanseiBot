using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;

namespace RanseiBeta
{
    public class MessageSender : IMessageSender
    {
        //private readonly SocketCommandContext context;
        //private readonly ICommandContext context;

        public MessageSender()
        {

        }

        //public MessageSender(ICommandContext context)
        //{
        //    this.context = context;
        //}

        //public MessageSender(SocketCommandContext context)
        //{
        //    this.context = context;
        //}

        public async Task SendMessage(ICommandContext context, string message)
        {
            await context.Channel.SendMessageAsync(message);
        }

        public async Task SendMessage(ICommandContext context, string message, Color colour)
        {
            EmbedBuilder embed = new EmbedBuilder
            {
                ////embed.WithColor(colour); //this makes a vertical coloured bar next to the message
                Description = message
            };

            //embed.WithAuthor(context.User); //adds your username and icon to the top of the post
            embed.WithImageUrl("..\\..\\..\\Images\\hop_battle_start.gif");

            await context.Channel.SendMessageAsync(null, false, embed.Build());
        }
    }
}
