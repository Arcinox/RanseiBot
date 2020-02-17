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
        public MessageSender()
        {

        }

        public async Task SendMessage(ICommandContext context, string message)
        {
            message = $"{context.User.Mention}{Environment.NewLine}{message}";
            await context.Channel.SendMessageAsync(message);
        }

        public async Task SendMessage(ICommandContext context, string message, Color colour)
        {
            EmbedBuilder embed = new EmbedBuilder
            {
                ////embed.WithColor(colour); //this makes a vertical coloured bar next to the message
                Description = $"{message}"
            };

            //embed.WithAuthor(context.User); //adds your username and icon to the top of the post


            await context.Channel.SendMessageAsync(null, false, embed.Build());
        }

        public async Task SendMessageWithImage(ICommandContext context, string message, string imageName)
        {
            imageName = $"..//..//..//Images//{imageName}";
            //EmbedBuilder embed = new EmbedBuilder
            //{
            //    ImageUrl = $"attachment://{imageName}"
            //};

            //await context.Channel.SendFileAsync(imageName, message, embed: null);
            await context.Channel.SendFileAsync(imageName, message, embed: null);
        }
    }
}
