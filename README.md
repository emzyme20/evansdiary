# evansdiary

Evan's Diary

# API

Nav to evans-diary-api

> go run main.go

# UI

Nav to evans-diary-ui

> npm run dev

# For edit and continue, using vite for UI and air for API

From the UI folder evans-diary-ui

> npm start
> It will run both and listen for edits and recompile and load as necessary

TODO:

- Ensure that iis url rewrite rule is configured so that any deep-linked URL refreshes or non-file routes are internally directed to your index.html file rather than throwing a 404 error.

web.config that needs to be put in IIS:

```
<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <system.webServer>
    <staticContent>
      <remove fileExtension=".webp" />
      <mimeMap fileExtension=".webp" mimeType="image/webp" />
      <remove fileExtension=".json" />
      <mimeMap fileExtension=".json" mimeType="application/json" />
      <remove fileExtension=".md" />
      <mimeMap fileExtension=".md" mimeType="text/markdown" />
    </staticContent>

    <rewrite>
      <rules>
        <rule name="SPA Fallback" stopProcessing="true">
          <match url=".*" />
          <conditions logicalGrouping="MatchAll">
            <add input="{REQUEST_URI}" pattern="^/(assets|content|images)/" negate="true" />
            <add input="{REQUEST_URI}" pattern="^/(favicon\.ico|icons\.svg)$" negate="true" />
            <add input="{REQUEST_FILENAME}" matchType="IsFile" negate="true" />
            <add input="{REQUEST_FILENAME}" matchType="IsDirectory" negate="true" />
          </conditions>
          <action type="Rewrite" url="/index.html" />
        </rule>
      </rules>
    </rewrite>
  </system.webServer>
</configuration>
```

Recommended deployment flow:

1. Run static build locally.
2. Upload dist output to hosting root.
3. Add SPA rewrite rule.
4. Test direct URL refresh on deep links (for example /family).
5. Verify static JSON path loads correctly.
