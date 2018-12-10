# FixerSharp

C# library to assist with currency conversion and exchange rates. Leverages the [Fixer.io](http://fixer.io/) API.

[![FixerSharp Nuget](https://img.shields.io/nuget/v/FixerSharp.svg?style=flat)](https://www.nuget.org/packages/FixerSharp)

## Installation

Can be installed as a [NuGet package](https://www.nuget.org/packages/FixerSharp). In the package manager console, enter the following:

```text
Install-Package FixerSharp
```

## Usage

### Configure API Access

The fixer.io service now requires an API key for all operations. A free key allowing up to 1000 requests/month can be obtained by registering for a free account on the [fixer.io website](https://fixer.io/signup/free).

Your API key must be configured through the `SetApiKey` method before performing any conversion operations. This should only be required once during application startup (or equivalent):

```c#
using FixerSharp;

...

public class Startup
{
    ...

    public void Configure(IApplicationBuilder app)
    {
        ...

        // One-time call to SetApiKey
        Fixer.SetApiKey("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
    }
}
```

### Convert

Perform a one-off conversion between two currencies:

```c#
using FixerSharp;

...

double oneHundredUsdInGbp = Fixer.Convert(Symbols.USD, Symbols.GBP, 100);
double oneThousandEurInUsd = await Fixer.ConvertAsync("EUR", "USD", 1000);
```

### Exchange Rate

If you wish to perform additional conversions, the current exchange rate can be retrieved and used to convert:

```c#
using FixerSharp;

...

ExchangeRate rateUsdGbp = Fixer.Rate(Symbols.USD, Symbols.GBP);

double oneHundredUsdInGbp = rateUsdGbp.Convert(100);
double oneThousandUsdInGbp = rateUsdGbp.Convert(1000);
double tenThousandUsdInGbp = rateUsdGbp.Convert(10000);

ExchangeRate rateGbpEur = await Fixer.RateAsync(Symbols.GBP, Symbols.EUR);

double tenGbpInEur = rateGbpEur.Convert(10);
double oneHundredGbpInEur = rateGbpEur.Convert(100);
```

*This method is recommended if you have more than one conversion to perform, as data is only retrieved from the fixer API once.*

### Previous Data

Both `Convert` and `Rate` have date support, allowing access to historical currency data for any day since 1999.

```c#
using FixerSharp;

...

// Calculates percentage difference of 100 GBP in USD between Nov 2015/16
double amount = Fixer.Convert(Symbols.GBP, Symbols.USD, 100, new DateTime(2016, 11, 01));
double amountPrevious = Fixer.Convert(Symbols.GBP, Symbols.USD, 100, new DateTime(2015, 11, 01));

double percentDifference = (amount - amountPrevious) / amountPrevious * 100; // -20.2952... :(

// Get the exchange rate for EUR => GBP on 1st January 2015
ExchangeRate historicalRate = Fixer.Rate(Symbols.EUR, Symbols.GBP);

double historicalConversion = historicalRate.Convert(500);
```

## Acknowledgements

This makes use of the [fixer](https://github.com/fixerAPI/fixer) project to provide up-to-date exchange rates.