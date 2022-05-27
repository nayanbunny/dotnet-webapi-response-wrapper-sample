# .Net 6 API Middleware Response Wrapper Sample

Version: >= 6.0<br/>
Language: C#<br/>

---

## Dependencies

Microsoft.AspNetCore.App<br/>
Microsoft.AspNetCore.Http<br/>
Microsoft.AspNetCore.Http.Extensions<br/>
Microsoft.NetCore.App<br/>
Newtonsoft.Json<br/>

---

## Description

**Middleware** is software that's assembled into an app pipeline to handle requests and responses. ASP.NET Core provides a rich set of built-in middleware components, but in some scenarios you might want to write a custom middleware.

Each component:

- Chooses whether to pass the request to the next component in the pipeline.
- Can perform work before and after the next component in the pipeline.

![Middleware](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/middleware/index/_static/request-delegate-pipeline.png?view=aspnetcore-6.0)

<br/>

> **Middleware** is generally encapsulated in a class and exposed with an extension method.

<br/>

The middleware class must include:<br/>

- A public constructor with a parameter of type RequestDelegate.
- A public method named Invoke or InvokeAsync. This method must:
  - Return a Task.
  - Accept a first parameter of type HttpContext.
- Additional parameters for the constructor and Invoke/InvokeAsync are populated by dependency injection (DI).
  Typically, an extension method is created to expose the middleware through IApplicationBuilder.

![Middleware Order](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/middleware/index/_static/middleware-pipeline.svg?view=aspnetcore-6.0)

---

## Execution Steps

1. Pre-requisites: .Net 6 and Visual Studio IDE.
2. Launch .sln file in Visual Studio IDE.
3. Build the Solution or API project.
4. Run the API project.
5. Swagger UI will be available at _/swagger/index.html_
6. Select Endpoint, Try it out and Execute.
7. Custom Formatted Response will be displayed under Response section.

---

## References

[Middleware](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/middleware/?view=aspnetcore-6.0)

[Custom Middleware](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/middleware/write?view=aspnetcore-6.0)
