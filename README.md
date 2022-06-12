# .Net 6 API Middleware Response Wrapper Sample

`Middleware` is software that's assembled into an app pipeline to handle requests and responses. ASP.NET Core provides a rich set of built-in middleware components, but in some scenarios you might want to write a custom middleware.

Each component:

- Chooses whether to pass the request to the next component in the pipeline.
- Can perform work before and after the next component in the pipeline.

<div align="center">

![Middleware](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/middleware/index/_static/request-delegate-pipeline.png?view=aspnetcore-6.0)

</div>
<br/>

> **Middleware** is generally encapsulated in a class and exposed with an extension method.

<br/>

The middleware class must include:<br/>

- A public constructor with a parameter of type `RequestDelegate`.
- A public method named `Invoke` or `InvokeAsync`. This method must:
  - Return a Task.
  - Accept a first parameter of type `HttpContext`.
- Additional parameters for the constructor and Invoke/InvokeAsync are populated by dependency injection (DI).
  Typically, an extension method is created to expose the middleware through `IApplicationBuilder`.

<div align="center">

![Middleware Order](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/middleware/index/_static/middleware-pipeline.svg?view=aspnetcore-6.0)

</div>

Language: `C#`<br/>
.Net Version: `>=6.0`<br/>

## **Dependencies**

- Microsoft.AspNetCore.App
- Microsoft.AspNetCore.Http
- Microsoft.AspNetCore.Http.Extensions
- Microsoft.NetCore.App
- Newtonsoft.Json

## **Pre-requisites**

- .Net SDK
- Visual Studio IDE

## **Execution Steps**

1. Launch .sln file in `Visual Studio IDE`.
2. Build the Solution or API project.
3. Run the API project.
4. `Swagger UI` will be available at `/swagger/index.html`
5. Select Endpoint, Try it out and Execute.
6. Custom formatted response will be displayed under response section.

## **References**

[Middleware](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/middleware/?view=aspnetcore-6.0)<br/>
[Custom Middleware](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/middleware/write?view=aspnetcore-6.0)

### :fire: Happy Coding
