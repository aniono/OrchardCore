using OrchardCore.Modules.Manifest;
using OrchardCore.OpenId;

[assembly: Module(
    Name = "OpenID",
    Author = "The Orchard Team",
    Website = "http://orchardproject.net",
    Version = "2.0.0"
)]

[assembly: Feature(
    Id = OpenIdConstants.Features.Core,
    Name = "OpenID Core Components",
    Category = "OpenID Connect",
    Description = "Registers the core components used by the OpenID module."
)]

[assembly: Feature(
    Id = OpenIdConstants.Features.Management,
    Name = "OpenID Management Interface",
    Category = "OpenID Connect",
    Description = "Allows adding, editing and removing the registered applications.",
    Dependencies = new[] { OpenIdConstants.Features.Core }
)]

[assembly: Feature(
    Id = OpenIdConstants.Features.Server,
    Name = "OpenID Authorization Server",
    Category = "OpenID Connect",
    Description = "Enables authentication of external applications using the OpenID Connect/OAuth 2.0 standards.",
    Dependencies = new[]
    {
        OpenIdConstants.Features.Core,
        OpenIdConstants.Features.Management,
        "OrchardCore.Users",
        "OrchardCore.Roles"
    }
)]

[assembly: Feature(
    Id = OpenIdConstants.Features.Validation,
    Name = "OpenID Token Validation",
    Category = "OpenID Connect",
    Description = "Validates tokens issued by the Orchard OpenID server or by a remote server supporting JWT and OpenID Connect discovery.",
    Dependencies = new[]
    {
        OpenIdConstants.Features.Core
    }
)]
