@echo off
REM ============================================================
REM Generate C# API client from local OpenAPI spec
REM ============================================================

SETLOCAL

REM --- Configuration ---
SET API_URL=https://localhost:7265/openapi/v1.json
SET OUTPUT_DIR=.
SET PACKAGE_NAME=BlazorTemplate.Client.ApiClient
SET TARGET_FRAMEWORK=net8.0

echo.
echo ===============================================
echo Downloading OpenAPI specification...
echo ===============================================
curl -k -L "%API_URL%" -o openapi.json

IF %ERRORLEVEL% NEQ 0 (
    echo.
    echo ❌ Failed to download OpenAPI spec from %API_URL%
    pause
    EXIT /B 1
)

echo.
echo ===============================================
echo Generating C# API client...
echo ===============================================

npx @openapitools/openapi-generator-cli generate -i ./openapi.json -g csharp -o . --global-property apis --additional-properties=targetFramework=net8.0,packageName=BlazorTemplate.Client.ApiClient,generateClientInterfaces=true,useHttpClientCreationMethod=true,optionalAssemblyInfo=false,validatable=false,skipSchemaGeneration=true,generateApiTests=false,generateModelTests=false,generateApiDocumentation=false,generateModelDocumentation=false

IF %ERRORLEVEL% NEQ 0 (
    echo.
    echo ❌ OpenAPI Generator failed.
    pause
)

echo.
echo ✅ Client generation completed successfully!
echo Output: %OUTPUT_DIR%
echo ===============================================

ENDLOCAL
pause