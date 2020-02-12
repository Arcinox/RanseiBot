using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RanseiBeta
{
    public interface IMessageSender
    {
        Task SendMessage(ICommandContext context, string message);
        Task SendMessage(ICommandContext context, string message, Color colour);
        //Task SendMessage(string message);
    }
}
