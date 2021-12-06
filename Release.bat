@ECHO off

DEL /q package
dotnet clean Samples\Samples.sln -c Release

dotnet pack Samples\Samples.sln -c Release -o build