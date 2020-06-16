using OrchardCore.DisplayManagement.Manifest;
using OrchardCore.Modules.Manifest;

[assembly: Theme(
    Name = "The Admin Theme",
    Author = "Antoine Griffard",
    Website = "http://www.antoinegriffard.com",
    Version = "1.0.0",
    Description = "Custom admin theme",
    BaseTheme = "TheAdmin",
    Tags = new[] { ManifestConstants.AdminTag }
)]
