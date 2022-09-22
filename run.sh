#!/usr/bin/env bash
rm -fr ./pub
dotnet publish ./ConfigBenchmark.csproj -c Release -o pub
OuterSection__InnerSection__Key=1 && dotnet pub/ConfigBenchmark.dll