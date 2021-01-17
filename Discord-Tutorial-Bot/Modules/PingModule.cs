using Discord.Commands;
using System.Threading.Tasks;

public class PingModule : ModuleBase<SocketCommandContext>
{
    [Command("ping")]
    [Summary("Ping Pong!")]
    public async Task PingAsync()
    {
        await ReplyAsync("pong");
    }
}

