<div align="center">

# C# wrapper for [Fortnite-API.com](https://fortnite-api.com)

[![GitHub release](https://img.shields.io/github/v/release/Fortnite-API/csharp-wrapper?logo=github)](https://github.com/Fortnite-API/csharp-wrapper/releases/latest) [![Nuget](https://img.shields.io/nuget/v/Fortnite-API-Wrapper?logo=nuget)](https://www.nuget.org/packages/Fortnite-API-Wrapper) ![Nuget DLs](https://img.shields.io/nuget/dt/Fortnite-API-Wrapper?logo=nuget) [![GitHub issues](https://img.shields.io/github/issues/Fortnite-API/csharp-wrapper?logo=github)](https://github.com/Fortnite-API/csharp-wrapper/issues) [![GitHub License](https://img.shields.io/github/license/Fortnite-API/csharp-wrapper)](https://github.com/Fortnite-API/csharp-wrapper/blob/master/LICENSE) [![Donate](https://img.shields.io/badge/donate-PayPal-blue.svg?logo=paypal)](https://fortnite-api.com/paypal) [![Discord](https://discordapp.com/api/guilds/621452110558527502/widget.png?style=shield)](https://fortnite-api.com/discord)

</div>

This library offers a complete wrapper around the endpoints of [fortnite-api.com](https://fortnite-api.com).

## NuGet

    Install-Package Fortnite-API-Wrapper

## Documentation

Here is a quick overview of the API so you can get started very quickly.

If you need an in-use example then please take a look at the [program.cs](https://github.com/Fortnite-API/csharp-wrapper/blob/master/src/Fortnite-API.Test/Program.cs) in my test folder where i use some of the endpoints.

- General usage

```cs
using Fortnite_API;

var api = new FortniteApi();
```

- FortniteApi class

```cs
var api = new FortniteApi();

// accesses the shop endpoint (https://fortnite-api.com/shop)
api.Shop...

// accesses the cosmetics endpoint (https://fortnite-api.com/cosmetics)
api.Cosmetics...

// accesses the news endpoint (https://fortnite-api.com/news)
api.News...
```

### Contribute

If you can provide any help, may it only be spell checking please contribute!

We are open for any contribution.

## License

- Fortnite-API (MIT) [License](https://github.com/Fortnite-API/csharp-wrapper/blob/master/LICENSE "MIT License")
- RestSharp (Apache 2.0) [License](https://github.com/restsharp/RestSharp/blob/master/LICENSE.txt)
- Newtonsoft.Json (MIT) [License](https://github.com/JamesNK/Newtonsoft.Json/blob/master/LICENSE.md)

API developed by [Fortnite-API.com](https://fortnite-api.com/about)