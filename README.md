# element-blazor.github.io

Element-Blazor demo components and the WebAssembly demo site published to GitHub Pages.

## Projects

- `demo.csproj`: reusable Razor demo components used by the documentation site.
- `site/Element.ClientRender.csproj`: browser-rendered documentation and demo shell.

## Local Run

From the Element-Blazor root repository:

```powershell
dotnet run --project demo/site/Element.ClientRender.csproj
```

The site uses local `src/Components` and `src/Markdown` project references when it is built inside the root repository.
