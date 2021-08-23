using System;
using System.Threading.Tasks;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;

public class MyFirstModule : BaseCommandModule
{

    [Command("randomnumber")]
    public async Task RandomCommand(CommandContext ctx, int min, int max)
    {
        var random = new Random();
        await ctx.RespondAsync($"Seu número é {random.Next(min, max)}");
    }


    [Command("olá")]
    public async Task GreetCommand(CommandContext ctx, DiscordMember member)
    {
        await ctx.RespondAsync($"Oopa {member.Mention}. Valeu por executar esse comando **FODA**. Ah, e espero que tenha gostado da menção");
    }

    
    [Command("commands")]
    public async Task HelpCommand(CommandContext ctx, [RemainingText] string name)
    {
        await ctx.RespondAsync($"Oopa {name}. por enquanto a gente só tem 1 comando (!olá [seu nome])");
    }
}
