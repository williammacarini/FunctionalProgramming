namespace FunctionalProgramming.Api.Controllers

open Microsoft.AspNetCore.Mvc
open Microsoft.Extensions.Logging

[<ApiController>]
[<Route("[controller]")>]
type ValueController (logger : ILogger<ValueController>) = 
    inherit ControllerBase()

    [<HttpGet>]
    member this.Get() =
        ValueClient.getData()

    //[<HttpGet("{id}")>]
    //member this.Get(id:int) =
    //    "value"

    //[<HttpPost>]
    //member this.Post([<FromBody>]value:string) =
    //    ()

    //[<HttpPut("{id}")>]
    //member this.Put(id:int, [<FromBody>]value:string ) =
    //    ()

    //[<HttpDelete("{id}")>]
    //member this.Delete(id:int) =
    //    ()