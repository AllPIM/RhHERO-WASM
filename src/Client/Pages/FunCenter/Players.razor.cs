using FSH.BlazorWebAssembly.Client.Components.EntityTable;
using FSH.BlazorWebAssembly.Client.Infrastructure.ApiClient;
using FSH.BlazorWebAssembly.Client.Infrastructure.Common;
using FSH.WebApi.Shared.Authorization;
using Mapster;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using MudBlazor;

namespace FSH.BlazorWebAssembly.Client.Pages.FunCenter;

public partial class Players
{
    [Inject]
    protected IPlayersClient PlayersClient { get; set; } = default!;

    protected EntityClientTableContext<PlayerDto, Guid, object> Context { get; set; } = default!;

    protected override void OnInitialized() =>
        Context = new(
            entityName: L["Player"],
            entityNamePlural: L["Players"],
            entityResource: FSHResource.Players,
            fields: new()
            {
                new(player => player.Id, L["Id"], "Id"),
                new(player => player.Name, L["Name"], "Name")
            },
            idFunc: player => player.Id);

    public class RelatedPlayer : PlayerDto
    {
        public bool ShowDetails { get; set; }
        public DateTime LocalTime { get; set; }
    }
}
