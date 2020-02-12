using Discord;
using Discord.Commands;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RanseiBeta.Enums;

namespace RanseiBeta
{
    ////public class Test123<MODEL>
    ////{
    ////    public IEnumerable<MODEL> GetByInterface(Type typeOfInterface, IDictionary<int, MODEL> dictionary)
    ////    {
    ////        return dictionary.Values.Where(x => x.GetType() == typeOfInterface);
    ////    }
    ////}

    public class CommandModule : ModuleBase<SocketCommandContext>
    {
        private readonly IDiceRoller diceRoller;
        private readonly IMessageSender messageSender;

        public CommandModule(IDiceRoller diceRoller, IMessageSender messageSender)
        {
            this.diceRoller = diceRoller;
            this.messageSender = messageSender;
        }

        [Command("hello")]
        private async Task HelloCommand()
        {
            await messageSender.SendMessage(Context, $"My, how spirited! Hello @{Context.User.Username}#{Context.User.Discriminator}!", Color.Red);
            ////await ReplyAsync($"My, how spirited! Hello @{Context.User.Username}#{Context.User.Discriminator}!");
        }

        [Command("roll")]
        private async Task DiceRollCommand()
        {
            var result = diceRoller.RollD6();
            await ReplyAsync($"Dice rolled: {result}");
        }

        [Command("raffle")]
        private async Task RaffleCommand(params string[] raffleEntrants) //may need to be params Type[]
        {
            //if we only have one entry, check for other delimiters (spaces, pipes)

            try
            {
                int numberOfEntrants = raffleEntrants.Length;
                if (numberOfEntrants > 0)
                {
                    int raffleWinnerIndex = diceRoller.RollDice(numberOfEntrants) - 1;

                    await ReplyAsync($"The winner is {raffleEntrants[raffleWinnerIndex]}");
                }
                else
                {
                    await ReplyAsync($"The raffle entrants were unclear!");
                }
            }
            catch (Exception ex)
            {
                await ReplyAsync($"Oops, something went wrong! Error: {ex.Message}");
            }
        }

        [Command("fish")]
        private async Task FishingCommand(string ranseiEventName = null)
        {
            RanseiEvent ranseiEvent = RanseiEvent.None;
            switch (ranseiEventName)
            {
                case "Halloween2019":
                case "H2019":
                case "H19":
                    ranseiEvent = RanseiEvent.Halloween2019; break;
                case "RanseiVSGalar":
                case "RvG":
                    ranseiEvent = RanseiEvent.RanseiVSGalar; break;
                default:
                    ranseiEvent = RanseiEvent.None; break;
            }

            try
            {
                FishingRewards fishingRewards = new FishingRewards(ranseiEvent);

                int numberRolled = diceRoller.RollDice(100);
                
                Reward reward = fishingRewards.GetFishingReward(numberRolled);
                string description = string.Empty;
                if (reward is ITraitable)
                {
                    ITraitable traitableReward = reward as ITraitable;
                    traitableReward.RollTrait();
                    if (traitableReward.Trait != null)
                    {
                        description = $"{traitableReward.Trait.ToString()} ";
                    }
                }
                description += reward.Name;

                await ReplyAsync($"Congratulations! You hooked a {description}!{Environment.NewLine}{Environment.NewLine}(Actual number rolled: {numberRolled})");
            }
            catch (Exception ex)
            {
                await ReplyAsync($"Oops, something went wrong! Error: {ex.Message}");
            }
        }
    }
}
