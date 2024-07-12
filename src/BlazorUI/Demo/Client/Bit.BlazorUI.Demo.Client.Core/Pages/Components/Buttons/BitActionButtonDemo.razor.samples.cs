﻿namespace Bit.BlazorUI.Demo.Client.Core.Pages.Components.Buttons;

public partial class BitActionButtonDemo
{
    private readonly string example1RazorCode = @"
<BitActionButton IconName=""@BitIconName.AddFriend"">Create account</BitActionButton>
<BitActionButton IconName=""@BitIconName.AddFriend"" ReversedIcon>Reversed Icon</BitActionButton>
<BitActionButton IconName=""@BitIconName.AddFriend"" IsEnabled=""false"">Disabled</BitActionButton>
<BitActionButton>No Icon</BitActionButton>";

    private readonly string example2RazorCode = @"
<BitActionButton IconName=""@BitIconName.Globe"" Href=""https://bitplatform.dev"" Target=""_blank"">
    Open bitplatform.dev
</BitActionButton>
<BitActionButton IconName=""@BitIconName.Globe"" Href=""https://github.com/bitfoundation/bitplatform"">
    Go to bitplatform GitHub
</BitActionButton>";

    private readonly string example3RazorCode = @"
<BitActionButton Color=""BitColor.Primary"" IconName=""@BitIconName.ColorSolid"">Primary</BitActionButton>
<BitActionButton Color=""BitColor.Primary"">Primary</BitActionButton>

<BitActionButton Color=""BitColor.Secondary"" IconName=""@BitIconName.ColorSolid"">Secondary</BitActionButton>
<BitActionButton Color=""BitColor.Secondary"">Secondary</BitActionButton>

<BitActionButton Color=""BitColor.Tertiary"" IconName=""@BitIconName.ColorSolid"">Tertiary</BitActionButton>
<BitActionButton Color=""BitColor.Tertiary"">Tertiary</BitActionButton>

<BitActionButton Color=""BitColor.Info"" IconName=""@BitIconName.ColorSolid"">Info</BitActionButton>
<BitActionButton Color=""BitColor.Info"">Info</BitActionButton>

<BitActionButton Color=""BitColor.Success"" IconName=""@BitIconName.ColorSolid"">Success</BitActionButton>
<BitActionButton Color=""BitColor.Success"">Success</BitActionButton>

<BitActionButton Color=""BitColor.Warning"" IconName=""@BitIconName.ColorSolid"">Warning</BitActionButton>
<BitActionButton Color=""BitColor.Warning"">Warning</BitActionButton>

<BitActionButton Color=""BitColor.SevereWarning"" IconName=""@BitIconName.ColorSolid"">SevereWarning</BitActionButton>
<BitActionButton Color=""BitColor.SevereWarning"">SevereWarning</BitActionButton>

<BitActionButton Color=""BitColor.Error"" IconName=""@BitIconName.ColorSolid"">Error</BitActionButton>
<BitActionButton Color=""BitColor.Error"">Error</BitActionButton>";

    private readonly string example4RazorCode = @"
<BitActionButton Size=""BitSize.Small"" IconName=""@BitIconName.FontSize"">Small</BitActionButton>
<BitActionButton Size=""BitSize.Medium"" IconName=""@BitIconName.FontSize"">Medium</BitActionButton>
<BitActionButton Size=""BitSize.Large"" IconName=""@BitIconName.FontSize"">Large</BitActionButton>";

    private readonly string example5RazorCode = @"
<style>
    .custom-class {
        color: burlywood;
    }

    .custom-icon {
        font-size: 1rem;
        font-weight: bold;
    }

    .custom-content {
        font-size: 1.5rem;
    }
</style>


<BitActionButton IconName=""@BitIconName.ThisPC"" Style=""color:brown"">
    Styled Action Button
</BitActionButton>
<BitActionButton IconName=""@BitIconName.ThisPC"" Class=""custom-class"">
    Classed Action Button
</BitActionButton>


<BitActionButton IconName=""@BitIconName.CustomActivity""
                 Styles=""@(new() { Icon = ""font-size:1.5rem"", Content = ""font-size:1rem"" })"">
    Action Button Styles
</BitActionButton>
<BitActionButton IconName=""@BitIconName.CustomActivity""
                 Classes=""@(new() { Icon = ""custom-icon"", Content = ""custom-content"" })"">
    Action Button Classes
</BitActionButton>";

    private readonly string example6RazorCode = @"
<BitActionButton IconName=""@BitIconName.AddFriend"">
    <div style=""display:flex;gap:0.5rem;"">
        <div>This is a custom template</div>
        <BitSpinnerLoading Size=""20"" />
    </div>
</BitActionButton>";

    private readonly string example7RazorCode = @"
<EditForm Model=""validationButtonModel"" OnValidSubmit=""HandleValidSubmit"">
    <DataAnnotationsValidator />

    <ValidationSummary />

    <BitTextField Label=""Required"" Required @bind-Value=""validationButtonModel.RequiredText"" />
    <ValidationMessage For=""() => validationButtonModel.RequiredText"" style=""color:red"" />

    <BitTextField Label=""Nonrequired"" @bind-Value=""validationButtonModel.NonRequiredText"" />

    <div>
        <BitActionButton IconName=""@BitIconName.SendMirrored"" ButtonType=""BitButtonType.Submit"">Submit</BitActionButton>
        <BitActionButton IconName=""@BitIconName.Reset""  ButtonType=""BitButtonType.Reset"">Reset</BitActionButton>
        <BitActionButton IconName=""@BitIconName.ButtonControl"" ButtonType=""BitButtonType.Button"">Button</BitActionButton>
    </div>
</EditForm>";
    private readonly string example7CsharpCode = @"
public class ButtonValidationModel
{
    [Required]
    public string RequiredText { get; set; } = string.Empty;

    public string? NonRequiredText { get; set; }
}

private ButtonValidationModel validationButtonModel = new();

private async Task HandleValidSubmit()
{
    await Task.Delay(2000);

    validationButtonModel = new();

    StateHasChanged();
}";

    private readonly string example8RazorCode = @"
<BitActionButton Dir=""BitDir.Rtl"" IconName=""@BitIconName.AddFriend"">ساخت حساب</BitActionButton>";

}
