# ETCars .NET SDK

.NET Core 2 event driven client for [ETCars](https://etcars.menzelstudios.com/).

It connects to ETCars socket and provide fully tipized data via event handlers.

## Usage

```
ETCarsClient client = new ETCarsClient();
client.DataReceived += client_DataReceived;
client.Connect();

private void client_DataReceived(ETCarsDataReceivedArgs args)
{
    Console.WriteLine(args.RawData);
}
```

ETCarsDataReceivedArgs contains RawData (raw json data in string) and Data, fully typized value object with the class ETCarsData .

## Events

* DataRecived
* Connected
* Disconnected
